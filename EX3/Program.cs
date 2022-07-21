class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        int y = 15;
        int z = 20;
        int k = 30;
        int Media;

        Console.WriteLine("Digite o primeiro número: " + x);
        Console.WriteLine("Digite o segundo número " + y);
        Console.WriteLine("Digite o terceiro número " + z);
        Console.WriteLine("Digite o quarto número " + k);
        
        Media = ((x + y + z + k)/4) ;

        Console.WriteLine("A média de 10, 15, 20, 30 é: " + Media);
    }
}