using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace Hotel_Management.Contexts
{
    public class DbContext
    {
        SqlConnection conn;
        public SqlConnection Connection
        {
            get => conn;
            set => conn = value;
        }

        public DbContext()
        {
            conn = new SqlConnection();
        }

        public void UseConnectionString(string connStr)
        {
            conn.ConnectionString = connStr;
        }

        // Sử dụng ConnectionStrings trong app.config
        public void UseConfigurationManager(string name)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public IEnumerable<T> GetTable<T>(Func<T, bool> predicate = null)
        {
            List<T> result = new List<T>();
            Type type = typeof(T);
            TableAttribute attribute = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (attribute == null)
                return result;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {attribute.Name}";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                PropertyInfo[] properties = type.GetProperties();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T curr = (T)Activator.CreateInstance(typeof(T));
                    foreach (PropertyInfo property in properties)
                    {
                        string column = ((ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute))).Name;
                        if (column.Length == 0)
                            continue;
                        string propertyName = property.Name;
                        object data = null;
                        Type propertyType = property.PropertyType;
                        if (reader[column].ToString().Length == 0)
                            continue;
                        if (propertyType == typeof(int))
                        {
                            data = int.Parse(reader[column].ToString());
                        }
                        else if (propertyType == typeof(DateTime))
                        {
                            data = DateTime.Parse(reader[column].ToString());
                        }
                        else if (propertyType == typeof(string))
                        {
                            data = reader[column].ToString();
                        }
                        else if (propertyType == typeof(float))
                        {
                            data = float.Parse(reader[column].ToString());
                        }
                        else if (propertyType == typeof(double))
                        {
                            data = double.Parse(reader[column].ToString());
                        } else if (propertyType == typeof(bool))
                        {
                            if (reader[column].ToString() == "1")
                                data = true;
                            else
                                data = false;
                        }
                        property.SetValue(curr, data, null);
                    }
                    if (predicate != null)
                    {
                        if (predicate(curr))
                            result.Add(curr);
                    }
                    else
                        result.Add(curr);
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                
            }
            return result;
        }

        public bool AddRow<T>(T data)
        {
            bool result = false;
            if (data == null)
                return result;
            Type type = typeof(T);
            TableAttribute tableAttribute = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttribute == null)
                return result;
            List<string> keys = new List<string>();
            List<object> values = new List<object>();

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                ColumnAttribute columnAttribute = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
                if (columnAttribute == null || columnAttribute.IsIdentity)
                    continue;
                object value = property.GetValue(data, null);
                if (value == null || value.ToString().Length == 0)
                    continue;
                Type propertyType = property.PropertyType;
                if (propertyType == typeof(int) || propertyType == typeof(float) || propertyType == typeof(double))
                    values.Add(value);
                else if (propertyType == typeof(DateTime))
                {
                    DateTime dt = (DateTime)value;
                    if (dt.Year == 1)
                        continue;
                    else
                        values.Add($"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'");
                }
                else if (propertyType == typeof(bool))
                {
                    if ((bool)value)
                        values.Add(1);
                    else
                        values.Add(0);
                }
                else
                    values.Add($"N'{value}'");
                keys.Add(columnAttribute.Name);
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO {tableAttribute.Name} ({string.Join(", ", keys)}) VALUES ({string.Join(", ", values)})";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                
            }
            return result;
        }

        public bool UpdateRow<T>(T data)
        {
            bool result = false;
            if (data == null)
                return result;
            Type type = typeof(T);
            TableAttribute tableAttribute = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttribute == null)
                return result;

            List<string> sets = new List<string>();
            List<string> where = new List<string>();

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties) 
            {
                ColumnAttribute columnAttribute = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
                if (columnAttribute == null) continue;
                object value = property.GetValue(data, null);
                Type propertyType = property.PropertyType;
                object formarttedValue = null;
                if (columnAttribute.IsPrimaryKey)
                {
                    if (propertyType == typeof(int) || propertyType == typeof(float) || propertyType == typeof(double))
                        formarttedValue = value;
                    else if (propertyType == typeof(DateTime))
                    {
                        DateTime dt = (DateTime)value;
                        if (dt.Year == 1)
                            continue;
                        else
                            formarttedValue = $"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'";
                    }
                    else if (propertyType == typeof(bool))
                    {
                        if ((bool)value)
                            formarttedValue = 1;
                        else
                            formarttedValue = 0;
                    }
                    else
                        formarttedValue = $"N'{value}'";
                    where.Add($"{columnAttribute.Name} = {formarttedValue}");
                } else
                {
                    if (propertyType == typeof(int) || propertyType == typeof(float) || propertyType == typeof(double))
                        formarttedValue = value;
                    else if (propertyType == typeof(DateTime))
                    {
                        DateTime dt = (DateTime)value;
                        if (dt.Year == 1)
                            continue;
                        else
                            formarttedValue = $"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'";
                    }
                    else if (propertyType == typeof(bool))
                    {
                        if ((bool)value)
                            formarttedValue = 1;
                        else
                            formarttedValue = 0;
                    }
                    else
                        formarttedValue = $"N'{value}'";
                    sets.Add($"{columnAttribute.Name} = {formarttedValue}");
                }
            } 
            if (where.Count == 0)
                return result;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE {tableAttribute.Name} SET {string.Join(", ", sets)} WHERE {string.Join(", ", where)}";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static bool IsValidConnStr(string connStr)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
