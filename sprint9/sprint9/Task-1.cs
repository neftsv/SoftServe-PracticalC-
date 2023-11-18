using System.Threading.Tasks;


class Calc
{
    public int Seq(int n)
    {
        return (int)Math.Pow(n, 2);
    }
}

class CalcAsync
{
    public static async Task PrintSeqAsync(int n)
    {
        Calc calculator = new Calc();

        int result = await Task.Run(() => calculator.Seq(n));

        Console.WriteLine($"Seq[{n}] = {result}");
    }
}

class p
{
    static async Task Main()
    {
        await CalcAsync.PrintSeqAsync(1);
        await CalcAsync.PrintSeqAsync(2);
        await CalcAsync.PrintSeqAsync(3);
        await CalcAsync.PrintSeqAsync(4);
        await CalcAsync.PrintSeqAsync(5);
    }
}