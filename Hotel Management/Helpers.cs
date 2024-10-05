using System;

namespace Hotel_Management
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }
        public string IdentityColumn { get; set; }

        public TableAttribute(string name, string identityColumn = "")
        {
            Name = name;
            IdentityColumn = identityColumn;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; set; }

        public ColumnAttribute(string name)
        {
            Name = name;
        }
    }

    public static class Helpers
    {

    }
}
