using System.Collections.Generic;
using System.Linq;

class MyProgram
{
    public static void Position(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 5) Console.WriteLine(i + 1);
        }
    }

    public static void Remove(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 20)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }
        for (int i = 0; i < numbers.Count; i++)
            Console.WriteLine(numbers[i]);
    }

    public static void Insert(List<int> numbers)
    {
        numbers.Insert(2, -5);
        numbers.Insert(5, -6);
        numbers.Insert(7, -7);
        for (int i = 0; i < numbers.Count; i++)
            Console.WriteLine(numbers[i]);
    }

    public static void Sort(List<int> numbers)
    {
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
            Console.WriteLine(numbers[i]);
    }
}