internal class Task_3
{
    public static int ProductWithCondition(List<int> integers, Func<int, bool> predicate)
    {
        List<int> newIntegers = new List<int>();
        for (int i = 0; i < integers.Count; i++)
        {
            if (predicate(integers[i]))
                newIntegers.Add(integers[i]);
        }

        if (newIntegers.Count == 0) return 1;

        int res = 1;
        for (int i = 0; i < newIntegers.Count; i++)
        {
            res *= newIntegers[i];
        }
        return res;
    }
}

