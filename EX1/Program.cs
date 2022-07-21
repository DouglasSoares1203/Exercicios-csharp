using System;

class Program
{
    public static void Main(string[] args)
    {
        int x = 5;
        int y = 6;

        Console.WriteLine("Digite primeiro numero");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite segundo numero");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine("O valor do primeiro número esperado é: " + (x = 6));
        Console.WriteLine("O valor do primeiro número esperado é: " + (y = 5));

        Console.ReadKey();

    }
}