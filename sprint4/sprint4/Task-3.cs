public enum ColourEnum
{
    Red,
    Green,
    Blue
}

interface IColoured
{
    ColourEnum Colour { get { return ColourEnum.Red; } }
}

interface IDocument
{
    static string defaultText = "Lorem ipsum";
    public int Pages { get { return 0; } set { Pages = 0; } }
    public string Name { get; set; }
    public void AddPages(int numberOfPages)
    {
        Pages += numberOfPages;
    }

    public void Rename(string newName)
    {
        Name = newName;
    }
}

class ColouredDocument : IDocument, IColoured
{
    public int Pages { get; set; }
    public string Name { get; set; }
    public ColourEnum Colour { get; set; }

    public ColouredDocument()
    {

    }

    public ColouredDocument(ColourEnum colour)
    {

    }
}

class Example
{
    public static void Do()
    {
        ColouredDocument doc1 = new ColouredDocument();
        doc1.Name = "Document1";
        Console.WriteLine(doc1.Name);
        ((IDocument)doc1).Rename("Document2");
        Console.WriteLine(doc1.Name);
    }
}