using System;

namespace esAmicali
{
	internal class Program
	{
		private static void Main(string[] args)
		{

			int num1, num2, somma1=0, somma2=0;

			Console.WriteLine("Programma che controlla se due numeri sono amici o amicali");
			Console.Write("Inserisci il primo numero: ");

			bool control = int.TryParse(Console.ReadLine(), out num1);

			while (!control || num1 <= 0)
			{
				Console.Write("Spiacente, ma il numero inserito non è valido, reinserire: ");
				control = int.TryParse(Console.ReadLine(), out num1);
			}

			Console.Write("Inserisci il secondo numero: ");
			control = int.TryParse(Console.ReadLine(), out num2);

			while (!control || num2 <= 0)
			{
				Console.Write("Spiacente, ma il numero inserito non è valido, reinserire: ");
				control = int.TryParse(Console.ReadLine(), out num2);
			}

			for (int i = 1; i < num1; i++)
			{
				if (num1 % i == 0)
				{
					somma1 += i;
				}
			}

			for (int j = 1; j < num2; j++)
			{
				if (num2 % j == 0)
				{
					somma2 += j;
				}
			}

			if (somma1 == num2 && somma2 == num1)
			{
				Console.WriteLine($"I numeri {num1} e {num2} sono numeri amicali");
			}
			else
			{
				Console.WriteLine($"I numeri {num1} e {num2} NON sono numeri amicali");
			}
		}
	}
}