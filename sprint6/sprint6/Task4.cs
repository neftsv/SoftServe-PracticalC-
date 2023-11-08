using System.Collections.Generic;
class ShowPowerRange
{
    public static IEnumerable<int> PowerRanger(int degree, int start, int finish)
    {
        if (start > finish || start < 0 || finish < 0 || degree < 0)
        {
            yield return 0;
        }
        else if (start < finish)
        {
            if (degree == 0) { yield return 1; yield break; }
            int result = 1;
            for (int i = 1; result < finish; i++)
            {
                result = i;
                for (int j = 1; j < degree; j++)
                {
                    result *= i;
                }
                if (result <= finish && result >= start)
                    yield return result;
            }
        }
    }
}