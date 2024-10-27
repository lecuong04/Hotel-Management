using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

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

        public IEnumerable<T> GetTable<T>(Expression<Func<T, bool>> predicate = null, int page = 1, int size = 0)
        {
            List<T> result = new List<T>();
            if (page < 1 || size < 0)
                return result;
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null)
                return result;
            SqlCommand cmd = conn.CreateCommand();
            string condition = predicate != null ? $"WHERE {ExpressionToSql.ToSql(predicate)}" : "";
            cmd.CommandText = $"SELECT * FROM {tableAttr.Name} {condition} ORDER BY (SELECT NULL) OFFSET {(page - 1) * size} ROWS";
            if (size > 0)
                cmd.CommandText += $" FETCH NEXT {size} ROWS ONLY";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                PropertyInfo[] properties = type.GetProperties();
                Debug.WriteLine(cmd.CommandText);
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
                        if (predicate.Compile()(curr))
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
                Debug.WriteLine(ex);
            }
            return result;
        }

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
                        values.Add($"'{(DateTime)value:yyyy-MM-dd HH:mm:ss}'");
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
                Debug.WriteLine(cmd.CommandText);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
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
                }
                catch { 
                    reader.Close();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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
                            fValue = $"'{(DateTime)value:yyyy-MM-dd HH:mm:ss}'";
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
                            fValue = $"'{(DateTime)value:yyyy-MM-dd HH:mm:ss}'";
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
            cmd.CommandText = $"UPDATE {tableAttr.Name} SET {string.Join(", ", sets)} WHERE {string.Join(" AND ", where)}";
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                Debug.WriteLine(cmd.CommandText);
                if (cmd.ExecuteNonQuery() != 0)
                    result = true;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return result;
        }

        public bool DeleteRow<T>(T obj)
        {
            if (obj == null)
                return false;
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null) return false;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                List<string> where = new List<string>();
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    ColumnAttribute columnAttr = (ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute));
                    if (columnAttr == null) continue;
                    object value = property.GetValue(obj, null);
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
                                fValue = $"'{(DateTime)value:yyyy-MM-dd HH:mm:ss}'";
                        }
                        else if (pType == typeof(bool))
                            fValue = (bool)value ? 1 : 0;
                        else
                            fValue = $"N'{value}'";
                        where.Add($"{columnAttr.Name} = {fValue}");
                    }
                }
                if (where.Count == 0) return false;
                cmd.CommandText = $"DELETE FROM {tableAttr.Name} WHERE {string.Join(" AND ", where)}";
                Debug.WriteLine(cmd.CommandText);
                int result = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                if (result == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }

        public int DeleteRows<T>(Expression<Func<T, bool>> predicate)
        {
            int result = 0;
            Type type = typeof(T);
            TableAttribute tableAttr = (TableAttribute)type.GetCustomAttribute(typeof(TableAttribute));
            if (tableAttr == null) return result;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string condition = ExpressionToSql.ToSql(predicate);
                if (condition.Length == 0)
                    return result;
                else
                    condition = $"WHERE {condition}";
                cmd.CommandText = $"DELETE FROM {tableAttr.Name} {condition}";
                Debug.WriteLine(cmd.CommandText);
                result += cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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

    public static class ExpressionToSql
    {
        public static string ToSql<T>(Expression<Func<T, bool>> expression) => new SqlExpressionVisitor().Translate(expression.Body, typeof(T));

        private class SqlExpressionVisitor : ExpressionVisitor
        {
            private StringBuilder sb;
            private Dictionary<string, string> columns;
            private bool isContainsMethod = false;

            private Dictionary<string, string> GetColumns(Type type)
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                foreach (PropertyInfo property in type.GetProperties())
                    result.Add(property.Name, ((ColumnAttribute)property.GetCustomAttribute(typeof(ColumnAttribute))).Name);
                return result;
            }

            public string Translate(Expression expression, Type type)
            {
                columns = GetColumns(type);
                sb = new StringBuilder();
                Visit(expression);
                if (!isContainsMethod)
                    return sb.ToString();
                else
                    return string.Empty;
            }

            protected override Expression VisitBinary(BinaryExpression node)
            {
                sb.Append("(");
                Visit(node.Left);
                sb.Append($" {GetSqlOperator(node.NodeType)} ");
                if (node.Right.Type == typeof(DateTime))
                {
                    var lambda = Expression.Lambda(node.Right);
                    var value = lambda.Compile().DynamicInvoke();
                    if (value is DateTime dateValue)
                        sb.Append($"'{dateValue:yyyy-MM-dd HH:mm:ss}'");
                    else
                        sb.Append(value);
                }
                else
                    Visit(node.Right);
                sb.Append(")");
                return node;
            }

            protected override Expression VisitMember(MemberExpression node)
            {
                sb.Append(columns[node.Member.Name]);
                return node;
            }

            protected override Expression VisitConstant(ConstantExpression node)
            {
                if (node.Type == typeof(string))
                    sb.Append($"N'{node.Value}'");
                else
                    sb.Append(node.Value);
                return node;
            }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                isContainsMethod = true;
                Debug.WriteLine($"Skip: {node.Method.Name}");
                return node;
            }

            private string GetSqlOperator(ExpressionType type)
            {
                switch (type)
                {
                    case ExpressionType.Equal:
                        return "=";
                    case ExpressionType.NotEqual:
                        return "<>";
                    case ExpressionType.GreaterThan:
                        return ">";
                    case ExpressionType.GreaterThanOrEqual:
                        return ">=";
                    case ExpressionType.LessThan:
                        return "<";
                    case ExpressionType.LessThanOrEqual:
                        return "<=";
                    case ExpressionType.AndAlso:
                        return "AND";
                    case ExpressionType.OrElse:
                        return "OR";
                    default:
                        throw new NotSupportedException($"Operator {type} is not supported.");
                }
            }
        }
    }

}