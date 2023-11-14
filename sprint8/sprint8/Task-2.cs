using System.Collections.Generic;
using System.Threading;


class MainThreadProgram
{
    public static (Thread, Thread) Calculator()
    {
        Thread sumThread = new Thread(Sum);
        Thread productThread = new Thread(Product);

        sumThread.Start();
        productThread.Start();
        return (sumThread, productThread);

    }

    public static void Product()
    {
        int[] Arr = new int[10];
        int product = 1;
        for(int integer = 0; integer < Arr.Length; integer++)
        {
            Arr[integer] = integer + 1;
            product *= Arr[integer];
        }
        Thread.Sleep(10000);

        Console.WriteLine($"Product is: {product}");
    }

    public static void Sum()
    {
        int sum = 0;
        
        for (int integer = 1; integer <= 5; integer++)
        {
            string str = "";
            switch (integer)
            {
                case 1: str = "st"; break;
                case 2: str = "nd"; break;
                case 3: str = "rd"; break;
                default: str = "th"; break;
            }
                
            Console.WriteLine($"Enter the {integer}{str} number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                sum += number;
            }
        }
        Console.WriteLine($"Sum is: {sum}");
    }
}