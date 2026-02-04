using System;
using static System.Console;

namespace esPercorsoRobot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int strada;
			bool movement = true, safe = false;
			WriteLine("Programma che valuta se una strada è sicura o meno da percorrere per un robot");
			Write("Inserisci il codice della strada: ");

			bool control = int.TryParse(ReadLine(), out strada);

			if (!control || strada.ToString().Length != 4)
			{
				WriteLine("Spiacente, il numero di strada inserito non è valido reinserire un codice di 4 cifre per la strada: ");
				control = int.TryParse(ReadLine(), out strada);
			}

			safe = StradaSicura(strada, ref movement);

			WriteLine();

			if (safe)
				WriteLine("Strada sicura");
			else
				WriteLine("Strada NON sicura");
		}

		static bool StradaSicura(int n, ref bool movement)
		{
			int prev = n % 10;
			n /= 10;
			int dir = 0;

			while (n > 0)
			{
				int curr = n % 10;
				n /= 10;

				int currentDir = 0;

				if (curr < prev)
				{
					currentDir = 1;
				}
				else if (curr > prev)
				{
					currentDir = -1;
				}
				else
				{
					return false;
				}

				if (dir == 0)
				{
					dir = currentDir;
				}
				else if (currentDir == dir)
				{
					return false;
				}

				dir = currentDir;
				prev = curr;
			}

			movement = true;
			return true;
		}
	}
}
