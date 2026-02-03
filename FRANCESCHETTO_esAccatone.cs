using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace esAccatone
{
	internal class Program
	{
		private static async Task Main(string[] args)
		{
			int quantità;
			float moneta, somma;
			quantità = 0;
			somma = 0;

			while (somma < 5)
			{
				Console.WriteLine("Inserisci il valore della moneta ottenuta: ");
				bool control = float.TryParse(Console.ReadLine(), out moneta);

				while (!control || moneta <= 0)
				{ 
					Console.WriteLine("Valore non valido, reinserire il valore della moneta ottenuta: ");
					control = float.TryParse(Console.ReadLine(), out moneta);
				}

				somma += moneta;
				Console.WriteLine($"Somma attuale: {somma} euro");
				quantità++;
			}
			Console.WriteLine($"Hai raccolto {quantità} monete per un totale di {somma} euro");
		}
	}
}