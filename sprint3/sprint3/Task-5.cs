using System;

public delegate void EventHandler();

class EventProgram{
    public event EventHandler Show;

    public EventProgram()
    {
        Show += Dog;
        Show += Cat;
        Show += Mouse;
        Show += Elephant;

        // Invoke the Show event
        Show.Invoke();
    }



    public static void Dog()
    {
        Console.WriteLine("Dog");
    }

    public static void Cat()
    {
        Console.WriteLine("Cat");
    }

    public static void Mouse()
    {
        Console.WriteLine("Mouse");
    }

    public static void Elephant()
    {
        Console.WriteLine("Elephant");
    }

}