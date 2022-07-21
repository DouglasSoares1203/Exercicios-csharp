 class Program
{
    public static void Main(string[] args)
    {
        int i, n;
        int[] a = new int[100];
        Console.WriteLine("Leia os números");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira {0} o número do elemento : \n", n);
        for ( i = 0; i < n; i++)
        {
            Console.Write("Elemento - {0}: ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nOs valores armazenados:  \n");
        for ( i = 0; i < n; i++)
        {
            Console.Write("{0} ", a[i]);
        }

        Console.Write("\n\nOs valores armazenados: \n");
        for ( i = n-1; i >= 0; i--)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.Write("\n\n");
    }
}