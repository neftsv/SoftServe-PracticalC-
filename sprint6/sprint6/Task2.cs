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

//public delegate bool Predicate<in T>(T obj);
public class Library
{
    public IEnumerable<Book> Books 
    { 
        get; 
        //private set;
    }
    public Predicate<Book> Filter { get; set; } = book => true;
    public Library(IEnumerable<Book> books)
    {
        Books = books;
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new MyEnumerator(Books, Filter);
    }
}

public sealed class MyEnumerator : IEnumerator<Book>
{
    private IEnumerable<Book> _books;
    private Predicate<Book> _filter;
    private IEnumerator<Book> _enumerator;

    public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
    {
        _books = books;
        _filter = filter;
        _enumerator = _books.GetEnumerator();
    }
    public Book Current { get { return _enumerator.Current; } }

    object IEnumerator.Current { get { return Current; } }

    public void Dispose()
    {
        _enumerator.Dispose();
    }

    public bool MoveNext()
    {
        while (_enumerator.MoveNext())
        {
            if (_filter(_enumerator.Current))
            {
                return true;
            }
        }
        return false;
    }

    public void Reset()
    {
        _enumerator.Reset();
    }
}

public class MyUtils
{
    public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book> filter)
    {
        var library = new Library(books);
        library.Filter = filter;
        var filteredBooks = new List<Book>();
        foreach (var book in library)
        {
            filteredBooks.Add(book);
        }
        return filteredBooks;
    }
}
