using System;
using static System.Console;

namespace esPiramide
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int height;
			WriteLine("Programma che crea una piramide di numeri alta quanto immesso in input");
			Write("Inserisci l'altezza della piramide: ");

			bool control = int.TryParse(ReadLine(), out height);

			while (!control || height <= 0)
			{
				WriteLine("Spiacente, il valore inserito non è valido. Reinserire: ");
				control = int.TryParse(ReadLine(), out height);
			}

			WriteLine();

			for (int i = 0; i < height; i++)
			{
				int c = 1;
				int dec = height;

				for (int j = 1; j <= height * 2 - 1; j++)
				{
					if (c >= height)
					{
						Write($"{dec}");
						dec--;
					}
					else
					{
						Write($"{c}");
						c++;
					}
				}

				WriteLine();
			}
		}
	}
}