using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        
        int[] matriz = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

        int sum = matriz.Sum();
        Console.WriteLine("O Resultado é: " + sum);
    }
}