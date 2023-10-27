abstract class Car
{
    internal string mark;
    internal int prodYear;

    public Car(string mark, int prodYear)
    {
        this.mark = mark;
        this.prodYear = prodYear;
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Mark: {mark}");
        Console.WriteLine($"Producted in {prodYear}");
    }
}

class SportCar : Car
{
    internal string mark;
    internal int prodYear;
    private int maxSpeed;

    public SportCar(string mark, int prodYear, int maxSpeed) : base(mark, prodYear)
    {
        this.mark = mark;
        this.prodYear = prodYear;
        this.maxSpeed = maxSpeed;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Max speed is {maxSpeed}");
    }
}


class Lory : Car
{
    internal int prodYear; 
    private double loadCapacity;

    public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
    {
        this.loadCapacity = loadCapacity;
    }
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"The load capacity is {loadCapacity}");
    }
}