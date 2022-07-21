using System;

 class Program
{
    public static void Main(string[] args)
    {
        int Letras;
        Console.WriteLine("Digite o número de letras menor que 26: ");
        Letras = Convert.ToInt32(Console.ReadLine());

        switch (Letras)
        {
            case 1:
            Console.Write("A");
            break;

            case 2:
            Console.Write("AB");
            break;

            case 3:
            Console.Write("ABC");
            break;

            case 4:
            Console.Write("ABCD");
            break;

            case 5:
            Console.Write("ABCDE");
            break;

            case 6:
            Console.Write("ABCDEF");
            break;

            case 7:
            Console.Write("ABCDEFG");
            break;

            case 8:
            Console.Write("ABCDEFGH");
            break;

            case 9:
            Console.Write("ABCDEFGHI");
            break;
            
            case 10:
            Console.Write("ABCDEFGHIJ");
            break;

            default:
            Console.WriteLine("Digitação inválida, do 11 ao 26 faltou construção");
            break;
        }

    }
}