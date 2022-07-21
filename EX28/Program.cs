using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        int[] frr1 = new int[100];
        int n,i,j,ctr;

        Console.WriteLine("Informar o número de elementos armazenados no array");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe {0} elemento contido no array: \n",n);
        for ( i = 0; i < n; i++)
        {
            Console.Write("elemento - {0} : ",i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
            frr1[i] = -1;
        }

        for ( i = 0; i < n; i++)
        {
            ctr = 1;
            for ( j = i+1; j < n; j++)
            {
                if (arr1[i] == arr1[j])
                {
                    ctr++;
                    frr1[j] = 0;
                }
            }
            if (frr1[i]!=0)
            {
                frr1[i] = ctr;
            }
        }

        Console.Write("\n A frequência de todos os elementos do array: \n");
        for (i = 0; i < n; i++)
        {
            if (frr1[i]!=0)
            {
                Console.Write("{0} ocorre {1} tempo\n ", arr1[i],frr1[i]);
                
            }
        }
    }
}