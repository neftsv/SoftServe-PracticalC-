using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

class MyTasks
{
    public static void Tasks()
    {
        int[] sequence_array = new int[10];
        Task[] tasks1 = new Task[3]
        {
            new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    sequence_array[i] = i * i;
                }
                Console.WriteLine("Calculated!");
            }),

            new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Bye!");
            }),
            new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                 Console.WriteLine(sequence_array[i]);
                }
                Console.WriteLine("Bye!");
            })
        };
        foreach (var task in tasks1)
        {
            task.Start();
            task.Wait(100); //я не впевнений що саме це малось на увазі, це якось по лінивому зроблено (там про порядок виконання)
        }

        Task.WaitAll(tasks1);
        Console.WriteLine("Main done!");
    }
}
