using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x1, x2;
            float delta = 0;

            Console.WriteLine("Inserisci il coefficiente a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il coefficiente b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il coefficiente c:");
            c = int.Parse(Console.ReadLine());

            delta = (b * b) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("L'equazione non ha soluzioni reali");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"L'equazione ha una soluzione reale doppia: x = {x1}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"L'equazione ha due soluzioni reali distinte: x1 = {x1} e x2 = {x2}");
            }

        }
    }
}