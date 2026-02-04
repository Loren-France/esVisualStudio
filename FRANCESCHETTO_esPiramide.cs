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

			for (int i = 1; i <= height; i++) //FOR per gestire le righe di altezza della piramide
			{
				int c = 1; // Parte da 1 fino al numero in mezzo
				int dec = i; // Parte dal numero in mezzo fino a 1

				for (int k = height - i; k >= 1; k--) //FOR per mettere gli spazi vuoti prima dei numeri
				{
					Write(" ");
				}

				for (int j = 1; j < i * 2; j++)
				{

					if (c >= i)
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