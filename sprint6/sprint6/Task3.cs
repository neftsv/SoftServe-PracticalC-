using System.Collections.Generic;

class ShowPower
{
    public static IEnumerable<float> SuperPower(int number, int degree)
    {
        float result = number;
        if (degree > 0)
        {
            for (int i = 0; i < degree; i++)
            {
                yield return result;
                result *= number;
            }
        }
        else if(degree < 0)
        {
            for (int i = 0; i < -degree; i++)
            {
                yield return 1/result;
                result *= number;
            }
        }
        else
        {
            yield return 1;
        }
    }
}