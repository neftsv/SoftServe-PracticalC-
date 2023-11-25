using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sprint11_Task2
{
    class ReflectMethod
    {
        public static class Methods
        {
            public static void Hello(string parameter)
            {
                Console.WriteLine($"Hello:parameter={parameter}");
            }
            public static void Welcome(string parameter)
            {
                Console.WriteLine($"Welcome:parameter={parameter}");
            }
            public static void Bye(string parameter)
            {
                Console.WriteLine($"Bye:parameter={parameter}");
            }
        }
        public static void InvokeMethod(string[] parameters)
        {
            Type type = typeof(Methods);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);

            foreach (MethodInfo method in methods)
            {
                foreach (string parameter in parameters)
                {
                    method.Invoke(null, new object[] { parameter });
                }
            }
        }
    }
}
