using System;

class Program
{
    public static void Main(string[] args)
    {
        DateTime.IsLeapYear(2022);
        int idade, anoDeNascimento;

        Console.WriteLine("Insira a sua idade: " );
        idade = int.Parse(Console.ReadLine());

        anoDeNascimento = 2022 - idade; 

        Console.WriteLine("Idade é " + idade + " Ano de nascimento é: " + anoDeNascimento);

    }
}