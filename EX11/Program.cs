class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá");

        string string1 = "Olá, tudo bem?";

        Console.WriteLine(string1.StartsWith("Olá"));

        Console.WriteLine(string1.StartsWith("Olá",StringComparison.OrdinalIgnoreCase));
        
    }
}