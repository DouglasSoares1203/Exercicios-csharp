 class Program
{
    public static void Main(string[] args)
    {

        int[] arr = new int[10];
        int i;

        Console.Write(" Informar 10 elementos de array");
        for (i = 0 ; i < 10;  i++)
        {
            Console.Write("elemento - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Os elementos dentro do array são: ");
        for ( i = 0; i < 10; i++)
        {
            Console.Write(" {0} ", arr[i]);
        }
        Console.WriteLine("\n");
    }
}