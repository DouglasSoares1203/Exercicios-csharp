using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] a  = new int[100];
        int i, n, sum = 0;

        Console.Write("Informe o número do elemento sendo o armazenamento do array: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe {0} elemento do array: \n", n);
        for ( i = 0; i < n; i++)
        {
            Console.Write("elemento - {0} : ",i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        for ( i = 0; i < n; i++)
        {
            sum += a[i];
        }

        Console.WriteLine("Soma de todos os elementos armazenados no array é: {0} \n\n", sum);



    }
}