using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sprint11_Task4
{
    public class ReflectorAssembly
    {
        public class LargeBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }

            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }

        public class Box
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }

            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }

        public class SmallBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }

            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }

        public interface ILookingForBox
        {
            static void LookForBox(string size) { }
        }

        public interface IPackingBox
        {
            static void PackBox(string size) { }
        }

        public static void WriteAssemblies()
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (type.IsClass)
                {
                    Console.WriteLine($"Class: {type.Name}");
                    MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);

                    foreach (MethodInfo method in methods)
                    {
                        string size = type.Name;
                        Console.WriteLine($"Metod: {method.Name}");
                        //method.Invoke(null, new object[] { size });
                    }
                }
                else if (type.IsInterface)
                {
                    Console.WriteLine($"Interface: {type.Name}");
                }

                //Console.WriteLine();
            }
        }
    }
}
