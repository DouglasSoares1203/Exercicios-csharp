using System;

class Program
{
    public static void Main(string[] args)
    {
       

        Console.WriteLine("Digite um número: ");
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }

            
        }

        

    }
}