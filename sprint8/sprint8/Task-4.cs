using System.Threading;

class MyProgram
{
    public static void Counter(int number)
    {
        Task[] task1 = new Task[2]
        {
            new Task(()=>{
                int factorial = 1;
                for(int integer = 1; integer <= number; integer++)
                {
                    factorial *= integer;
                }
                Console.WriteLine($"Factorial is: {factorial}");
            }),

            new Task(() =>
            {
                int fibonacci = 0;
                if( number <= 0 ) {}
                else if( number == 1 ) { fibonacci = 1; }
                else 
                {
                    int []fibonacciArray = new int [number + 1];
                    fibonacciArray [0] = 0;
                    fibonacciArray [1] = 1;
                    for( int integer = 2; integer <= number; integer++)
                    {
                        fibonacciArray[integer] = fibonacciArray[integer - 1] + fibonacciArray[integer - 2];
                    }
                    fibonacci = fibonacciArray[number];
                }
                Console.WriteLine($"Fibbonaci number is: {fibonacci}");
            })
        };

        foreach( var task in task1 ) 
        {
            task.Start();
            task.Wait(100);
        }
        Task.WaitAll(task1);
    }

    static void Main()
    {
        Counter(4);
    }
}