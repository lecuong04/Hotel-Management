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
        public SqlConnection Connection { get; set; }

        // Sử dụng ConnectionStrings trong app.config
        public DbContext() { 
            Connection = new SqlConnection();
        }

        public void UseConnectionString(string connStr)
        {
            Connection.ConnectionString = connStr;
        }

        public void UseConfigurationManager(string name)
        {
            Connection.ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public IEnumerable<T> GetTable<T>(Func<T, bool> predicate = null)
        {
            Type type = typeof(T);
            List<T> result = new List<T>();
            TableAttribute attribute = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            SqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {attribute.Name}";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
                PropertyInfo[] properties = type.GetProperties();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T curr = (T)Activator.CreateInstance(typeof(T));
                    foreach (PropertyInfo property in properties)
                    {
                        string column = ((ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute))).Name;
                        string propertyName = property.Name;
                        object data;
                        Type propertyType = property.PropertyType;
                        if (propertyType == typeof(int))
                        {
                            data = int.Parse(reader[column].ToString());
                            Helpers.SetValue(curr, propertyName, data);
                        }
                        else if (propertyType == typeof(DateTime))
                        {
                            data = DateTime.Parse(reader[column].ToString());
                            Helpers.SetValue(curr, propertyName, data);
                        }
                        else if (propertyType == typeof(string))
                        {
                            data = reader[column].ToString();
                            Helpers.SetValue(curr, propertyName, data);
                        }
                    }
                    if (predicate != null)
                    {
                        if (predicate(curr))
                            result.Add(curr);
                    }
                    else
                        result.Add(curr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public static bool IsValidConnectionStr(string connStr)
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
