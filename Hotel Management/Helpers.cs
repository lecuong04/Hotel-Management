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

        public ColumnAttribute(string name)
        {
            Name = name;
        }
    }

    public class Helpers
    {
        public static void SetValue(object theObject, string theProperty, object theValue)
        {
            try
            {
                var msgInfo = theObject.GetType().GetProperty(theProperty);
                msgInfo.SetValue(theObject, theValue, null);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
