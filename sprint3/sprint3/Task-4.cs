static class IListExtensions
{
    public static void IncreaseWith(this List<int> list, int count)
    {
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += count;
            }
            //return list;
        }
    }
}

static class IEnumerableExtensions
{
    public static string ToString<T>(this IEnumerable<T> str)
    {
        string result = "[";
        foreach (var item in str)
        {
            if (result.Length > 1)
                result += ", ";
            result += item.ToString();
        }
        result += "]";
        return result;
    }
}