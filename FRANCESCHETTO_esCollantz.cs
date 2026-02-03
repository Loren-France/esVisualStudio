using System;

namespace esCollanz
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int num;
			Console.WriteLine("Programma che calcola la sequenza di Collatnz da un numero in input");
			Console.Write("Inserisci un numero: ");

			bool control = int.TryParse(Console.ReadLine(), out num);
			if (!control || num <= 0)
			{
				Console.WriteLine("Spiacente, il nuemro immesso nonn è valido, reinserire: ");
				control = int.TryParse(Console.ReadLine(), out num);
			}

			Console.WriteLine($"Ecco la sequenza di Collantz del numero {num}: ");

			while (num!=1)
			{
				Console.Write($" {num} ->");

				if (num % 2 == 0)
				{
					num = num / 2;
				}
				else
				{
					num = (num * 3) + 1;
				}
			}

			Console.Write($" {num} ");
		}
	}
}