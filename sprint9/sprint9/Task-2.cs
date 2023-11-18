using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint9_Task2
{
    class Calc
    {
        public static int Seq(int n)
        {
            return n * n;
        }
    }

    static class CalcAsync
    {
        public static async Task TaskPrintSeqAsync(int n)
        {
            int result = await Task.Run(() => Calc.Seq(n));

            Console.WriteLine($"Seq[{n}] = {result}");
            
        }
        public static void PrintStatusIfChanged(this Task task, TaskStatus taskStatus)
        {
            if (task.Status != taskStatus)
            {
                Console.WriteLine($"Task status changed: {task.Status}");
                // Update the previous status to the current status
                taskStatus = task.Status;
            }
        }
        static TaskStatus currentStatus;
        public static async Task TrackStatus(this Task task)
        {
            while (!task.IsCompleted)
            {
                task.PrintStatusIfChanged(currentStatus);
            }
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            // Example usage
            Task task = CalcAsync.TaskPrintSeqAsync(5);
            await task.TrackStatus();
        }
    }
}
