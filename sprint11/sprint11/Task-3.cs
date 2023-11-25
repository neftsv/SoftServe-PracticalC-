using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sprint11_Task3
{
    public class ReflectProperties
    {
        public class TestProperties
        {
            public string FirstName { get; set; }
            internal string LastName { get; set; }
            protected int Age { get; set; }
            private string PhoneNumber { get; set; }
        }

        public static void WriteProperties()
        {
            Type type = typeof(TestProperties);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Property name: {property.Name}");
                Console.WriteLine($"Property type: {property.PropertyType}");
                Console.WriteLine($"Read-Write:    {property.CanRead && property.CanWrite}");
                Console.WriteLine($"Accessibility: {GetAccessibility(property)}");
                Console.WriteLine();
            }
        }

        private static string GetAccessibility(PropertyInfo property)
        {
            if (property.GetMethod.IsPublic)
                return "Public";
            else if (property.GetMethod.IsFamily)
                return "Protected";
            else if (property.GetMethod.IsAssembly)
                return "Internal";
            else if (property.GetMethod.IsPrivate)
                return "Private";
            else
                return "Unknown";
        }
    }
}
