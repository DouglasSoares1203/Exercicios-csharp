using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] arr1;
        string temp;
        int n,i,j,l;

        Console.WriteLine(" Informe números de strings: ");
        n = Convert.ToInt32(Console.ReadLine());
        arr1 = new string[n];

        Console.Write("Informe {0} strings below: \n" , n);
        for ( i = 0; i < n; i++)
        {
            arr1[i] = Console.ReadLine();
        }

        l = arr1.Length;

        for ( i = 0; i < l; i++)
        {
            for ( j = 0; j < l-1; j++)
            {
                if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                {
                    temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }
            }
        }
            Console.WriteLine("\n\n Depois de sortear aparece um array");
            {
                for ( i = 0; i < l; i++)
                {
                    Console.WriteLine(arr1[i] + " ");
                }
            }

    }
}