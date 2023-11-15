using System;
using System.Threading;

class MyThreads
{
    public static readonly object Den = new object();
    public static readonly object Ada = new object();

    public static int n;
    public static int m;

    public Thread Thread1;
    public Thread Thread2;

    public MyThreads()
    {
        Thread1 = new Thread(() =>
        {
            lock (Ada)
            {
                for (int i = 0; i < 5; i++, n++)
                {
                    Console.WriteLine("Thread1 n = " + n);
                    
                }
                Thread.Yield();
                lock (Den)
                {
                    
                    for (int i = 0; i < 5; i++, m++)
                        Console.WriteLine("Thread1 m = " + m);
                    Console.WriteLine("Thread1 success!");
                }
            }
        });

        Thread2 = new Thread(() =>
        {
            lock (Den)
            {
               
                for (int i = 0; i < 5; i++, m++)
                    Console.WriteLine("Thread2 m = " + m);


                    for (int i = 0; i < 5; i++, n++)
                        Console.WriteLine("Thread2 n = " + n);
                    Console.WriteLine("Thread2 success!");

            }
        });
    }
}

class P
{
    static void Main()
    {
        MyThreads myThreads = new MyThreads();
        myThreads.Thread1.Start();
        myThreads.Thread2.Start();

        myThreads.Thread1.Join();
        myThreads.Thread2.Join();
    }
}