using System.Collections.Generic;
internal class Task_4
{
    public static string GetWord(string input, string seed)
    {
        string[] words = input.Split(' ');
        
        string longestWord = seed;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
                longestWord = words[i];
        }
        if (longestWord == "") return seed;

        string res = "";
        for (int i = 0; i < longestWord.Length; i++)
        {
            if (longestWord[i] == 'a' || res != "")
            {
                res += longestWord[i];
            }
        }
        return res;
    }
}
