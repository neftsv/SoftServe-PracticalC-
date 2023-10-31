interface IAnimal
{
    string Name { get { return ""; } }
    void Voice();
    void Feed();
}

class Dog : IAnimal
{
    public void Voice() { Console.WriteLine("Woof"); }
    public void Feed() { Console.WriteLine("I eat meat"); }

}

class Cat : IAnimal
{
    public void Voice() { Console.WriteLine("Mew"); }
    public void Feed() { Console.WriteLine("I eat mice"); }
}