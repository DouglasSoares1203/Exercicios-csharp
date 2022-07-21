using System;

class Program
{
    public static void Main(string[] args)
    {
        const int numeroQtd = 5;
        int[] numeros = new int[numeroQtd];
        int maior = 0 , posicao_maior = 0;
        
        System.Console.WriteLine("Informe 5 números inteiros: ");

        for (int i = 0; i < numeroQtd; i++)
        {
             Console.Write((i + 1) + "Números: ");
             numeros[i] = Convert.ToInt32(Console.ReadLine());

             if (i == 0)
             {
                maior = numeros[0];
             }
             else if(numeros[i] > maior)
             {
                maior = numeros[i];
                posicao_maior = i;
             }
        }

        Console.WriteLine( "O maior número é:" + maior );
        Console.WriteLine( "A posição do maior número é:" + posicao_maior );
        Console.Read();


    }
}