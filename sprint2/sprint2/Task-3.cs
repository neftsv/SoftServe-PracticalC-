class Science
{
    public virtual void Awards()
    {
        Console.WriteLine("We can obtain the Nobel Price");
    }
}

class Mathematics : Science
{
    public override void Awards()
    {
        Console.WriteLine("We don't need any awards, but we still can obtain The Abel Price that nobody else can!");
    }
}

class Physics : Science
{

}

