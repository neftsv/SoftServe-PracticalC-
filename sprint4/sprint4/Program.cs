public interface ISwimmable
{
    void Swim()
    {
        Console.WriteLine("I can swim!");
    }
}

interface IFlyable
{
    int MaxHeight { get { return 0; } }
    void Fly()
    {
        Console.WriteLine($"I can fly at {MaxHeight} meters height!");
    }
}

interface IRunnable
{
    int MaxSpeed { get { return 0; } }
    void Run()
    {
        Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
    }
}

interface IAnimal
{
    int LifeDuration { get { return 0; } }
    void Voice()
    {
        Console.WriteLine("No voice!");
    }
    void ShowInfo()
    {
        Console.WriteLine($"I am a {this.GetType().FullName} and I live approximately {LifeDuration} years.");
    }
}

class Cat : IAnimal, IRunnable
{
    public int MaxSpeed { get; set; }
    public int LifeDuration { set; get; }
    public void Voice()
    {
        Console.WriteLine("Meow!");
    }
}

class Eagle : IAnimal, IFlyable
{
    public int MaxHeight { set; get; }
    public int LifeDuration { set; get; }
}

class Shark : IAnimal, ISwimmable
{
    public int LifeDuration { set; get; }
}