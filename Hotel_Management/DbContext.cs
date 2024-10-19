using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Hotel_Management
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }

        public TableAttribute(string name)
        {
            Name = name;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsIdentity { get; set; }

        public ColumnAttribute(string name, bool isPrimaryKey = false, bool isIdentity = false)
        {
            Name = name;
            IsPrimaryKey = isPrimaryKey;
            IsIdentity = isIdentity;
        }
    }

    public class DbContext
    {
        public enum ConnectionType
        {
            ConnectionString,
            ConfigurationManager
        }

        SqlConnection conn;
        public SqlConnection Connection
        {
            get => conn;
            set => conn = value;
        }

        public DbContext(ConnectionType type, string text)
        {
            conn = new SqlConnection();
            if (type == ConnectionType.ConnectionString)
                conn.ConnectionString = text;
            else
                conn.ConnectionString = ConfigurationManager.ConnectionStrings[text].ConnectionString;
        }

        public IEnumerable<T> GetTable<T>(Func<T, bool> predicate = null)
        {
            List<T> result = new List<T>();
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null)
                return result;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {tableAttr.Name}";
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
                        object pValue = reader[column];
                        if (column.Length == 0 || pValue.ToString().Length == 0)
                            continue;
                        property.SetValue(curr, pValue, null);
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
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        //public bool AddRow<T>(T data)
        //{
        //    bool result = false;
        //    if (data == null)
        //        return result;
        //    Type type = typeof(T);
        //    TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
        //    if (tableAttr == null)
        //        return result;
        //    List<string> keys = new List<string>();
        //    List<object> values = new List<object>();

        //    PropertyInfo[] properties = type.GetProperties();
        //    foreach (PropertyInfo property in properties)
        //    {
        //        ColumnAttribute columnAttr = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
        //        if (columnAttr == null || columnAttr.IsIdentity)
        //            continue;
        //        object value = property.GetValue(data, null);
        //        if (value == null || value.ToString().Length == 0)
        //            continue;
        //        Type pType = property.PropertyType;
        //        if (pType == typeof(int) || pType == typeof(float) || pType == typeof(double))
        //            values.Add(value);
        //        else if (pType == typeof(DateTime))
        //        {
        //            DateTime dt = (DateTime)value;
        //            if (dt.Year == 1)
        //                continue;
        //            else
        //                values.Add($"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'");
        //        }
        //        else if (pType == typeof(bool))
        //        {
        //            if ((bool)value)
        //                values.Add(1);
        //            else
        //                values.Add(0);
        //        }
        //        else
        //            values.Add($"N'{value}'");
        //        keys.Add(columnAttr.Name);
        //    }
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = $"INSERT INTO {tableAttr.Name} ({string.Join(", ", keys)}) VALUES ({string.Join(", ", values)})";
        //    cmd.CommandType = CommandType.Text;
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //            conn.Open();
        //        if (cmd.ExecuteNonQuery() != 0)
        //            result = true;
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    return result;
        //}

        public T AddRow<T>(T data)
        {
            T result = (T)Activator.CreateInstance(typeof(T));
            if (data == null)
                return result;
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null)
                return result;
            List<string> keys = new List<string>();
            List<object> values = new List<object>();

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                ColumnAttribute columnAttr = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
                if (columnAttr == null || columnAttr.IsIdentity)
                    continue;
                object value = property.GetValue(data, null);
                if (value == null || value.ToString().Length == 0)
                    continue;
                Type pType = property.PropertyType;
                if (pType == typeof(int) || pType == typeof(float) || pType == typeof(double))
                    values.Add(value);
                else if (pType == typeof(DateTime))
                {
                    DateTime dt = (DateTime)value;
                    if (dt.Year == 1)
                        continue;
                    else
                        values.Add($"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'");
                }
                else if (pType == typeof(bool))
                {
                    if ((bool)value)
                        values.Add(1);
                    else
                        values.Add(0);
                }
                else
                    values.Add($"N'{value}'");
                keys.Add(columnAttr.Name);
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO {tableAttr.Name} ({string.Join(", ", keys)}) OUTPUT inserted.* VALUES ({string.Join(", ", values)})";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (PropertyInfo property in properties)
                    {
                        string column = ((ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute))).Name;
                        object pValue = reader[column];
                        if (column.Length == 0 || pValue.ToString().Length == 0)
                            continue;
                        property.SetValue(result, pValue, null);
                    }
                }                
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public bool UpdateRow<T>(T data)
        {
            bool result = false;
            if (data == null)
                return result;
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null)
                return result;

            List<string> sets = new List<string>();
            List<string> where = new List<string>();

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                ColumnAttribute columnAttr = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
                if (columnAttr == null) continue;
                object value = property.GetValue(data, null);
                Type pType = property.PropertyType;
                object fValue = null;
                if (columnAttr.IsPrimaryKey)
                {
                    if (pType == typeof(int) || pType == typeof(float) || pType == typeof(double))
                        fValue = value;
                    else if (pType == typeof(DateTime))
                    {
                        DateTime dt = (DateTime)value;
                        if (dt == new DateTime())
                            continue;
                        else
                            fValue = $"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'";
                    }
                    else if (pType == typeof(bool))
                        fValue = (bool)value ? 1 : 0;
                    else
                        fValue = $"N'{value}'";
                    where.Add($"{columnAttr.Name} = {fValue}");
                }
                else
                {
                    if (pType == typeof(int) || pType == typeof(float) || pType == typeof(double))
                        fValue = value;
                    else if (pType == typeof(DateTime))
                    {
                        DateTime dt = (DateTime)value;
                        if (dt.Year == 1)
                            continue;
                        else
                            fValue = $"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'";
                    }
                    else if (pType == typeof(bool))
                        fValue = (bool)value ? 1 : 0;
                    else
                        fValue = $"N'{value}'";
                    sets.Add($"{columnAttr.Name} = {fValue}");
                }
            }
            if (where.Count == 0)
                return result;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE {tableAttr.Name} SET {string.Join(", ", sets)} WHERE {string.Join(", ", where)}";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (cmd.ExecuteNonQuery() != 0)
                    result = true;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public int DeleteRows<T>(Func<T, bool> predicate)
        {
            int result = 0;
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null) return result;
            IEnumerable<T> list = GetTable<T>(predicate);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                foreach (T c in list)
                {
                    List<string> where = new List<string>();
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        ColumnAttribute columnAttr = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
                        if (columnAttr == null) continue;
                        object value = property.GetValue(c, null);
                        Type pType = property.PropertyType;
                        object fValue = null;
                        if (columnAttr.IsPrimaryKey)
                        {
                            if (pType == typeof(int) || pType == typeof(float) || pType == typeof(double))
                                fValue = value;
                            else if (pType == typeof(DateTime))
                            {
                                DateTime dt = (DateTime)value;
                                if (dt.Year == 1)
                                    continue;
                                else
                                    fValue = $"'{((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss")}'";
                            }
                            else if (pType == typeof(bool))
                                fValue = (bool)value ? 1 : 0;
                            else
                                fValue = $"N'{value}'";
                            where.Add($"{columnAttr.Name} = {fValue}");
                        }
                    }
                    cmd.CommandText = $"DELETE FROM {tableAttr.Name} WHERE {string.Join(", ", where)}";
                    result += cmd.ExecuteNonQuery();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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