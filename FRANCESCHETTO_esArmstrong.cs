using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace esArmstrong
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int number, temp, lenght, somm, pow;
			pow = 0;
			somm = 0;
			lenght = 0;

			Console.WriteLine("Programma che verifica se è stato immesso un numero di Armstrong");
			Console.WriteLine("Inserisci il numero da verificare: ");

			bool control = int.TryParse(Console.ReadLine(), out number);
			while (!control || number <= 0)
			{
				Console.WriteLine("Numero inserito non valido. Reinserire: ");
				control = int.TryParse(Console.ReadLine(), out number);
			}

			temp = number;

			while (temp > 0)
			{
				temp = temp / 10;
				lenght++;
			}

			temp = number;

			for (int i = 0; i < lenght; i++)
			{
				double digit = temp % 10;
				pow = (int)Math.Pow(digit, lenght);
				somm = somm + pow;
				temp = temp / 10;
			}

			if (somm == number)
			{
				Console.WriteLine($"Il numero {number} è un numero di Armstrong");
				}
			else
			{
				Console.WriteLine($"Il numero {number} NON è un numero di Armstrong");
			}
		}
	}
}