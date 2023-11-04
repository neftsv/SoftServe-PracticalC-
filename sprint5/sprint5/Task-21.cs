using System.Collections.Generic;


class MyUtils
{
    public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dictionary)
    {
        //if(list.Count < dictionary.Count) { return fa }
        foreach (var listPair in dictionary.Values) 
        {
            bool result = false;
            foreach(var dictionaryPair in list)
            {
                if(listPair == dictionaryPair)
                {
                    result = true;
                    break;
                }
            }
            if(!result)
                return false;
        }
        return true;
    }
    public static void Main(string[] args)
    {
        List<string> list1 = new List<string> { "aa", "bb", "aa", "cc" };
        Dictionary<string, string> dict1 = new Dictionary<string, string>
        {
            { "1", "cc" },
            { "2", "bb" },
            { "3", "cc" },
            { "4", "aa" },
            { "5", "cc" }
        };
        Console.WriteLine(ListDictionaryCompare(list1, dict1)); // Should return true

        List<string> list2 = new List<string> { "aa", "bb", "aa", "cc", "ddd" };
        Console.WriteLine(ListDictionaryCompare(list2, dict1)); // Should return false

        Dictionary<string, string> dict2 = new Dictionary<string, string>
        {
            { "1", "cc" },
            { "2", "bb" },
            { "3", "cc" },
            { "4", "aa" },
            { "5", "cc" },
            { "6", "ddd" }
        };
        Console.WriteLine(ListDictionaryCompare(list1, dict2)); // Should return false
    }
}