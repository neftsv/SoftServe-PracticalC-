static class StringExtensions
{ 
    public static int WorldCount(this string Sentence)
    {
        char[] split = { ' ', '.', '?', '!', '-', ';', ':', ',' };
        string[] words = Sentence.Split(split, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }
}

//namespace split3
//{
//    class P
//    {
//        static void Main()
//        {
//            string a = "Hello everyone, my name is Sviatoslav. I try to verify this method";
//            Console.WriteLine(a.WorldCount());
//        }
//    }
//}