static class StringExtensions
{ 
    public static int WorldCount(this string Sentence)
    {
        char[] split = { ' ', '.', '?', '!', '-', ';', ':', ',' };
        string[] words = Sentence.Split(split, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }
}