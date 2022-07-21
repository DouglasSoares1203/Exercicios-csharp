using System;

class Program
{
    public static void Main(string[] args)
    {
        double F, C;

        Console.WriteLine("Entre com Celsius");
        C = Convert.ToDouble(Console.ReadLine());

        F = (C * 1.8) + 32;
        Console.WriteLine("Celsiu:{0} -> Fahrenheit: {1}", C,F);
        Console.WriteLine("Fahrenheit:{0} -> Celsiu: {1}", F,C);

        Console.ReadLine();
    }
}