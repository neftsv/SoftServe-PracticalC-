using System.Collections;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }

    public Book(string title, string author, int pageCount)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
    }
}

public class Library
{
    public IEnumerable<Book> Books 
    { 
        get; 
        private set;
    }
    
}

//public sealed class MyEnumerator : //base interface here
//{
//    //your implementation
//}

public class MyUtils
{
    //your implementation
}
