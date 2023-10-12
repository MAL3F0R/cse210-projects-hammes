using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction t1 = new Fraction();
        Console.WriteLine(t1.GetFractionString());
        Console.WriteLine(t1.GetDecimalValue());
        
        Fraction t2 = new Fraction(5);
        Console.WriteLine(t2.GetFractionString());
        Console.WriteLine(t2.GetDecimalValue());

        Fraction t3 = new Fraction(3, 4);
        Console.WriteLine(t3.GetFractionString());
        Console.WriteLine(t3.GetDecimalValue());

        Fraction t4 = new Fraction(1, 3);
        Console.WriteLine(t4.GetFractionString());
        Console.WriteLine(t4.GetDecimalValue());
    }
}