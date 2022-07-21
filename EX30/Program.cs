using System;

class Program
{
    public static void Main(string[] args)
    {
        int i, pos, n;
        int[] arr1 = new int[50];

        Console.Write("Informe o tamanho do array: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe {0} elementos em array contido na ordem descrescente");
        for ( i = 0; i < n; i++)
        {
            Console.Write("elemento - {0}: ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n Informe a posição onde será deletado: ");
        pos = Convert.ToInt32(Console.ReadLine());
        i = 0;
        while (i!= pos - 1)
        i++;
            
        while (i<n)
        {
            arr1[i] = arr1[i+1];
            i++;
        }
        n--;
        Console.Write("\n A nova lista é: ");
        for ( i = 0; i < n; i++)
        {
            Console.Write(" {0}" , arr1[i]);
        }
            Console.Write("\n\n");
    }
}