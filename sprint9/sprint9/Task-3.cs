using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint9_Task3
{
    public class Calc
    {
        public static int Seq(int n)
        {
            return n * n;
        }
    }

    public class CalcAsync
    {
        public static async Task<int> SeqAsync(int n)
        {
            int result = await Task.Run(() => Calc.Seq(n));
            return result;
        }

        public static async void PrintSeqElementsConsequentlyAsync(int quant)
        {
            for (int i = 1; i <= quant; i++)
            {
                int result = await SeqAsync(i);
                Console.WriteLine($"Seq[{i}] = {result}");
            }
        }

        public static async void PrintSeqElementsInParallelAsync(int quant)
        {
            Task<int>[] tasks = GetSeqAsyncTasks(quant);
            await Task.WhenAll(tasks);

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Seq[{i}] = {tasks[i - 1].Result}");
            }
        }

        private static Task<int>[] GetSeqAsyncTasks(int quant)
        {
            Task<int>[] tasks = new Task<int>[quant];

            for (int i = 1; i <= quant; i++)
            {
                tasks[i - 1] = SeqAsync(i);
            }

            return tasks;
        }
    }
}