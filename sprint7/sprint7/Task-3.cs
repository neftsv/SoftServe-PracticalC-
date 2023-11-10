internal class Task_3
{
    public static int ProductWithCondition(List<int> integers, Func<int, bool> predicate)
    {
        if (integers.Count == 0) return 1;

        int res = 1;
        for (int i = 0; i < integers.Count; i++)
        {
            if (predicate(integers[i]))
                res *= integers[i];
        }
        return res;
    }
}