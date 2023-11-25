using System.Reflection;

namespace Sprint11_Task1
{
    class ReflectFields
    {
        public static string Name;
        public static int MeasureX;
        public static int MeasureY;
        public static int MeasureZ;
        public static void OutputFields()
        {
            Type type = typeof(ReflectFields);

            FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public);

            foreach (FieldInfo field in fields)
            {
                object value = field.GetValue(null);
                string fieldType = GetFieldType(field);
                Console.WriteLine($"{field.Name} ({fieldType}) = {value}");
            }
        }
        private static string GetFieldType(FieldInfo field)
        {
            Type fieldType = field.FieldType;

            if (fieldType == typeof(int))
            {
                return "int";
            }
            else if (fieldType == typeof(string))
            {
                return "string";
            }
            else
            {
                return fieldType.Name;
            }
        }
    }

    class p
    {
        static void Main()
        {
            // Set values for the fields
            ReflectFields.Name = "Sample Name";
            ReflectFields.MeasureX = 10;
            ReflectFields.MeasureY = 20;
            ReflectFields.MeasureZ = 30;

            // Call the OutputFields method to display the field information
            ReflectFields.OutputFields();
        }
    }
}