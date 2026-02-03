using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esStampaValori

{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int n, primo, trovati;
			trovati = 0;
			primo = 2;

			Console.WriteLine("Inserire il numero di N numeri da stampare: ");
			bool x = int.TryParse(Console.ReadLine(), out n);

			Console.WriteLine();

			if (!x || n <= 0)
			{
				Console.WriteLine("Il numero inserito non è valido");
				return;
			}
			else
			{
				Console.Write("Ecco la sequenza di numeri: ");
				while (trovati < n)
				{
					bool isPrimo = true;

					for (int j = 2; j * j <= primo; j++)
					{
						if (primo % j == 0)
						{
							isPrimo = false;
							break;
						}
					}

					if (isPrimo)
					{
						Console.Write($" {primo}");
						trovati++;
					}

					primo++;
				}

				Console.WriteLine();
			}
		}
	}
}