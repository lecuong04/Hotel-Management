using System;

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

    public static class Helpers
    {

    }
}
