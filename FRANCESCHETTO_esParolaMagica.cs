using System;
using static System.Console;

namespace esParolaMagica
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string parola;
			int c = 0;
			WriteLine("Programma che valuta se una parola si può considerare 'magica'");
			Write("Inserisci una parola: ");
			parola = ReadLine();

			if (parola == null)
			{
				WriteLine("Errore, non hai inserito nessuna parola, reinserire: ");
				parola = ReadLine();
			}

			for (int i = 0; i < parola.Length; i++)
			{
				if (parola[i] == 'a' || parola[i] == 'e' || parola[i] == 'i' || parola[i] == 'o' || parola[i] == 'u' || parola[i] == 'A' || parola[i] == 'E' || parola[i] == 'I' || parola[i] == 'O' || parola[i] == 'U')
				{
					c++;
				}
			}

			if (c >= 4)
			{
				WriteLine($"La parola '{parola}' è magica, in quanto contiene {c} vocali.");

			}
			else
			{
				WriteLine($"La parola '{parola}' NON è magica, in quanto contiene solo {c} vocali.");
			}
		}
	}
}