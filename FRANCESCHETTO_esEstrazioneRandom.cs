using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace esEstrazioneRandom
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			Random random = new Random();
			int difficulty, numero, scelta;
			int attemps = 5;
			bool vittoria = false;

			Console.WriteLine("Programma che simula l'estrazione casuale di numeri e si deve indovinare il numero");
			Console.WriteLine();
			Console.WriteLine("Inserire la difficolta a cui si vuole giocare: ");
			bool control = int.TryParse(Console.ReadLine(), out difficulty);

			while (!control || difficulty<1 || difficulty>3)
			{
				Console.WriteLine("La difficoltà immessa non è disponibile, reimmettere (1=facile,2=medio,3=difficile): ");
				control = int.TryParse(Console.ReadLine(), out difficulty);
			}

			if (difficulty == 1)
			{
				numero = random.Next(1, 6);
			}
			else if (difficulty == 2)
			{
				numero = random.Next(1, 11);
			}
			else
			{
				numero = random.Next(1, 21);
			}

			for (int i = attemps; i > 0; i--)
			{
				Console.WriteLine("Inserire un numero: ");
				control = int.TryParse(Console.ReadLine(), out scelta);
				Console.WriteLine();

				while(!control || scelta <= 0)
				{
					Console.WriteLine("Errore, non è stato immesso un numero oppure è stato immesso un numero non valido. Reimmettere: ");
					control = int.TryParse(Console.ReadLine(), out scelta);
				}

				if (scelta == numero)
				{
					Console.WriteLine($"Vittoria, il numero da indovinare era {numero}, complimenti!!!");
					vittoria = true;
					break;
				}
				else if (scelta < numero)
				{
					Console.WriteLine($"Numero troppo basso, hai a disposizione ancora {i-1} tentativi");
				}
				else
				{
					Console.WriteLine($"Numero troppo alto, hai a disposizione ancora {i-1} tentativi");
				}
			}

			if (vittoria == false)
			{
				Console.WriteLine($"Game over tentativi esauriti, il numero da indovinare era {numero}");
			}
		}
	}
}