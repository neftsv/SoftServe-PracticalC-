using System.Threading;

class MyProgram
{
    public static void Counter(int number)
    {
        Thread factorial = new Thread(() =>
        {
            Factorial(number);
        });

        Thread fibonacci = new Thread(() =>
        {
            Fibonacci(number);
        });

        factorial.Start();
        fibonacci.Start();

        factorial.Join();
        fibonacci.Join();
    }

    private static void Factorial(int number)
    {
        int factorial = 1;
        for (int integer = 1; integer <= number; integer++)
        {
            factorial *= integer;
        }
        Console.WriteLine($"Factorial is: {factorial}");
    }
    private static void Fibonacci(int number)
    {
        int fibonacci = 0;
        if (number <= 0) { }
        else if (number == 1) { fibonacci = 1; }
        else
        {
            int[] fibonacciArray = new int[number + 1];
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;
            for (int integer = 2; integer <= number; integer++)
            {
                fibonacciArray[integer] = fibonacciArray[integer - 1] + fibonacciArray[integer - 2];
            }
            fibonacci = fibonacciArray[number];
        }
        Console.WriteLine($"Fibbonaci number is: {fibonacci}");
    }
}