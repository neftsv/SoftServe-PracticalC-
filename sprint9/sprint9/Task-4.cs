using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint9_Task4
{
    class Calc
    {
        public static int Seq(int n)
        {
            return n * n;
        }
    }

    class CalcAsync
    {
        public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int result = await Task.Run(() => Calc.Seq(i));
                yield return (i, result);
            }
        }

        public static async void PrintStream(IAsyncEnumerable<(int, int)> stream)
        {
            await foreach (var tuple in stream)
            {
                Console.WriteLine($"Seq[{tuple.Item1}] = {tuple.Item2}");
            }
        }
    }
}
