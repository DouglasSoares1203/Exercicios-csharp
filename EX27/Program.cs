using System;

class Program
{
    private static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        int[] arr2 = new int[100];
        int i, n;

        Console.Write("Informe os números dos elementos armazenados do array: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe {0} elementos do array: \n", n);
        for ( i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for ( i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }

        Console.Write("\n\n Os elementos copiados entra os segundos array é :\n");
        for ( i = 0; i < n; i++)
        {
            Console.Write("{0} ", arr2[i]);
        }

        Console.WriteLine("\n\n");

    }
}