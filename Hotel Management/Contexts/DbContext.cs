using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Hotel_Management.Contexts
{
    public class DbContext
    {
        SqlConnection conn;
        public SqlConnection Connection { 
            get => conn; 
            set => conn = value;
        }

        // Sử dụng ConnectionStrings trong app.config
        public DbContext()
        {
            conn = new SqlConnection();
        }

        public void UseConnectionString(string connStr)
        {
            conn.ConnectionString = connStr;
        }

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

        public bool AddColumn<T>(T data)
        {
            bool result = false;
            if (data == null) 
                return false;
            Type type = typeof(T);
            TableAttribute attribute = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (attribute == null)
                return false;
            List<string> keys = new List<string>();
            List<object> values = new List<object>();

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                string column = ((ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute))).Name;
                if (column.Length == 0 || (column == attribute.IdentityColumn && attribute.IdentityColumn.Length != 0))
                    continue;
                object value = property.GetValue(data, null);
                if (value == null || value.ToString().Length == 0)
                    continue;
                keys.Add(column);
                Type propertyType = property.PropertyType;
                if (propertyType == typeof(int) || propertyType == typeof(float) || propertyType == typeof(double))
                    values.Add(value);
                else if (propertyType == typeof(DateTime))
                {
                    DateTime dt = (DateTime)value;
                    if (dt.Year == 1)
                        values.Add("NULL");
                    else
                        values.Add($"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'");
                }
                else
                    values.Add($"N'{value}'");
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO {attribute.Name} ({string.Join(", ", keys)}) VALUES ({string.Join(", ", values)})";
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
