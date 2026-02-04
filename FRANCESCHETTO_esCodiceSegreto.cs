using System;
using static System.Console;

namespace esCodiceSegreto
{
	class Program
	{
		static void Main(string[] args)
		{
			int cod;
			WriteLine("Programma che controlla se un codice segreto in input è valido o meno");
			WriteLine("Inserisci il codice da verificare: ");

			bool control = int.TryParse(ReadLine(), out cod);

			while (!control)
			{
				WriteLine("Errore, codice inserito non valido, reinserire il codice: ");
				control = int.TryParse(ReadLine(), out cod);
			}

			bool validate = ControlloValidità(cod);

			if (validate)
			{
				WriteLine($"Il codice {cod} è valido");
			}
			else
			{
				WriteLine($"Il codice {cod} NON è valido");
			}
		}

		static bool ControlloValidità(int c)
		{
			int somma = 0, prodotto = 1;
			bool val = false;
			while (c != 0)
			{
				int resto = c % 10;
				somma += resto;
				prodotto *= resto;
				c /= 10;
			}

			if (somma % 3 == 0 && prodotto % 2 == 0)
			{
				val = true;
			}
			else
			{
				val = false;
			}
			return val;
		}
	}
}

