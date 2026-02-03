using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esMCD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int ord1, ord2, MCD;

			Console.WriteLine("Programma che calcola MCD tra due numeri per un'azienda");
			Console.Write("Inserisci il primo numero: ");
			bool control1 = int.TryParse(Console.ReadLine(), out ord1);
			Console.Write("Inserisci il secondo numero: ");
			bool control2 = int.TryParse(Console.ReadLine(), out ord2);

			if (!control1 || !control2 || ord1 <= 0 || ord2 <= 0)
			{
				Console.WriteLine("Errore una delle quantità inserire non è disponibile, reinserire le quantità: ");
				Console.WriteLine("Reinserire il primo numero: ");
				control1 = int.TryParse(Console.ReadLine(), out ord1);
				Console.WriteLine("Reinserire il secondo numero: ");
				control2 = int.TryParse(Console.ReadLine(), out ord2);
				return;
			}

			if (ord1 > ord2)  
			{
				MCD = ord2;
			}
			else
			{
				MCD = ord1;
			}

			while (ord1 % MCD != 0 || ord2 % MCD != 0)
			{
				MCD--;
			}

			Console.WriteLine($"L'MCD tra {ord1} e {ord2} è : {MCD}");
		}
	}
}