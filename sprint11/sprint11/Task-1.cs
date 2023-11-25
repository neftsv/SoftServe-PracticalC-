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
}