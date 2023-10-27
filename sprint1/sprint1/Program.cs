using System.Collections;

class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x; 
        this.y = y;
    }

    internal int []GetXYPair()
    {
        int[] xy = new int[2];
        xy[0] = x;
        xy[1] = y;
        return xy;
    }

    protected internal double Distance(int x, int y) 
    {

        double d = Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        return d;
    }

    protected internal double Distance(Point p)
    {
        double d = Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
        return d;
    }
    public static explicit operator double(Point p)
    {

        return Math.Sqrt(Math.Pow(0 - p.x, 2) + Math.Pow(0 - p.y, 2)); ;
    }

}

class Fraction
{
    private readonly int numerator = 0;
    private readonly int denominator = 0;

    public Fraction(int numerator, int denominator)
    {
        //CheckNegative(Reduction());
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int commonDen = LCM(a.denominator, b.denominator);
        int num1 = a.numerator * (commonDen / a.denominator);
        int num2 = b.numerator * (commonDen / b.denominator);
        return CheckNegative(Reduction( new Fraction(num1 + num2, commonDen)));
    }

    public static Fraction operator +(Fraction a)
    {
        return a;
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        int commonDen = LCM(a.denominator, b.denominator);
        int num1 = a.numerator * (commonDen / a.denominator);
        int num2 = b.numerator * (commonDen / b.denominator);
        return CheckNegative(Reduction(new Fraction(num1 - num2, commonDen)));
    }

    public static Fraction operator -(Fraction a)
    {
        return CheckNegative(Reduction(new Fraction(-a.numerator, a.denominator)));
    }

    public static Fraction operator !(Fraction a)
    {
        return CheckNegative(Reduction(new Fraction(a.denominator, a.numerator)));
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {

        return CheckNegative(Reduction(new Fraction(a.numerator * b.numerator, a.denominator * b.denominator)));
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return CheckNegative(Reduction(new Fraction(a.numerator * b.denominator, a.denominator * b.numerator)));
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        a = Reduction(a);
        b = Reduction(b);
        if(a.numerator == b.numerator && a.denominator == b.denominator) return true;
        return false;
    }

    public static bool operator !=(Fraction first, Fraction second)
    {
        return !(first == second);
    }

    public override string ToString()
    {
        //return $"{numerator}/{denominator}".ToString();
        if (denominator < 0) { return String.Format("{0} / {1}", -numerator, -denominator); }
        return String.Format("{0} / {1}", numerator, denominator);

    }

    public static Fraction Reduction(Fraction a)
    {
        int gcd = GCD(a.numerator, a.denominator);
        return new Fraction(a.numerator / gcd, a.denominator/ gcd);
    }

    private static Fraction CheckNegative(Fraction a) //Я не придумав як то краще назвати
    {
        if (a.denominator < 0) return new Fraction(-a.numerator, -a.denominator);
        else return a;
    }
    private static int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public override bool Equals(Object obj)
    {
        if (obj == null) return false;
        else return true;
    }
}


namespace sprint1
{
    class Program
    {
        static int f(int a)
        {
            int t = a;
            for(int i = 0; i > t; i ++)
            {
                a = a * a-1;
                a--;
            }
            return a;
        }
        public static void Main()
        {
            
            Console.Write("Write t: ");
            double t = Convert.ToDouble( Console.ReadLine());
            
            Console.WriteLine(f(5));
        }
    }
}