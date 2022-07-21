using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1=0, num2=1, aux;

		for (int i = 0; i​​​​​​​ < 8; i++)
		{
			aux=num1;
			num1 = num2;
			num2 = num1 + aux;
			Console.WriteLine("{0}", num2);

		}

		Console.ReadKey();
    }
}