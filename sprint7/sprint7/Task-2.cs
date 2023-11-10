using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint7
{
    internal class Task_2
    {
        public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate)
        {
            double res = 0;
            for (int i = 0; i < inputData.Length; i++)
            {
                if (predicate(inputData[i], i))
                    res = aggregate(res, inputData[i]);
            }
            return res;
        }
    }
}
