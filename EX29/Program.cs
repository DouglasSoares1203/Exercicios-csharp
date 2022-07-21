using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        int i, max, min, n;

        Console.WriteLine("Informe o numero do elemento que pode ser armazenado");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe {0} elemento contido o array: ", n);
        for ( i = 0; i < n; i++)
        {
            Console.Write("elemento - {0}: ",i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        max = arr1[0];
        min = arr1[0];

        for ( i = 1; i < n; i++)
        {
            if (arr1[i]>max)
            {
                max = arr1[i];
            }

            if (arr1[i] < min)
            {
                min = arr1[i];
            }


        }

        Console.WriteLine("Maximo elemento é: {0}\n", max);
        Console.WriteLine("Minimo elemento é: {0}\n", min);
    }
}