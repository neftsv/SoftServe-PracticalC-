using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint11
{
    public class ReflectFullClass
    {
        public class MyClass : IInter1, IInter2, IInter3
        {
            public int fieldOne;
            public string fieldTwo;

            public int Prop1 { get; set; }
            public string Prop2 { get; set; }

            public void MethodOne()
            {
                Console.WriteLine("MethodOne");
            }

            public void MethodTwo()
            {
                Console.WriteLine("MethodTwo");
            }
        }

        public interface IInter1 { }
        public interface IInter2 { }
        public interface IInter3 { }

        public static void WriteAllInClass(Type type)
        {
            // Greeting
            Console.WriteLine($"Hello, {type.Name}!");

            // Get fields, properties, and methods
            var fields = type.GetFields();
            var properties = type.GetProperties();
            var methods = type.GetMethods();

            // Output the names of fields
            Console.WriteLine($"There are {fields.Length} fields in {type.Name}:");
            foreach (var field in fields)
            {
                Console.Write($"{field.Name}, ");
            }
            Console.WriteLine();

            // Output the names of properties
            Console.WriteLine($"There are {properties.Length} properties in {type.Name}:");
            foreach (var property in properties)
            {
                Console.Write($"{property.Name}, ");
            }
            Console.WriteLine();

            // Output the names of methods
            Console.WriteLine($"There are {methods.Length} methods in {type.Name}:");
            foreach (var method in methods)
            {
                Console.Write($"{method.Name}, ");
            }
            Console.WriteLine();

            // Get interfaces
            var interfaces = type.GetInterfaces().Distinct();

            // Output the names of interfaces
            Console.WriteLine($"There are {interfaces.Count()} interfaces in {type.Name}:");
            foreach (var inter in interfaces)
            {
                Console.Write($"{inter.Name}, ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Call the WriteAllInClass method to display information about MyClass
            ReflectFullClass.WriteAllInClass(typeof(ReflectFullClass.MyClass));

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
