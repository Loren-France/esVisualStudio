using System;
using static System.Console;

namespace esParolaMagica
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string parola;
			int c = 0; // conta vocali diverse trovate

			WriteLine("Programma che valuta se una parola si può considerare 'magica'");
			Write("Inserisci una parola: ");
			parola = ReadLine();

			while (parola == "")
			{
				Write("Errore, reinserisci una parola valida: ");
				parola = ReadLine();
			}

			char[] vocali = { 'a', 'e', 'i', 'o', 'u' };

			for (int i = 0; i < vocali.Length; i++)
			{
				if (parola.ToLower().Contains(vocali[i]))
				{
					c++;
				}
			}

			if (c >= 4)
			{
				WriteLine($"La parola '{parola}' è magica");
			}
			else
			{
				WriteLine($"La parola '{parola}' NON è magica");
			}
		}
	}
}
