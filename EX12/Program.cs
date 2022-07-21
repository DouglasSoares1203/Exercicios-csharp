using System;

class Program
{
    public static void Main(string[] args)
    {
         
         

         System.Console.WriteLine("Inserir o primeiro valor");
         int valor1 = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Inserir o segundo valor");
         int valor2 = int.Parse(Console.ReadLine());

        if (valor1 == 5 && valor2 == 15) 
        {
            Console.WriteLine("é próximo de 20");
        }
        else if(valor1 == valor2)
        {
            Console.WriteLine("retorna zero");
        }
        else
        {
            Console.WriteLine("O Valor será: " + (20 - 5));
        }
    }
}