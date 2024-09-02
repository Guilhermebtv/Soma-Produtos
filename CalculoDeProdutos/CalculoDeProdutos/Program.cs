using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistemas de Compras");
            Console.WriteLine("-------------------");
            Console.Write("\nProduto 1: ");
            string n1 = Console.ReadLine().Trim();

            Console.Write("Preço 1: R$");
            float p1;
            float.TryParse(Console.ReadLine(), out p1);

            Console.Write("Produto 2: ");
            string n2 = Console.ReadLine().Trim();

            Console.Write("Preço 2: R$");
            float p2;
            float.TryParse(Console.ReadLine(), out p2);

            Console.Write("Produto 3: ");
            string n3 = Console.ReadLine().Trim();

            Console.Write("Preço 3: R$");
            float p3;
            float.TryParse(Console.ReadLine(), out p3);

            Console.Write("Produto 4: ");
            string n4 = Console.ReadLine().Trim();

            Console.Write("Preço 4: R$");
            float p4;
            float.TryParse(Console.ReadLine(), out p4);

            Console.SetCursorPosition(0, 15);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{" Produto",-20} {"Preço ",13}");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{n1,-20} {p1,13:C2}");
            Console.WriteLine($"{n2,-20} {p2,13:C2}");
            Console.WriteLine($"{n3,-20} {p3,13:C2}");
            Console.WriteLine($"{n4,-20} {p4,13:C2}");
            Console.WriteLine($"{"Total",-20} {(p1 + p2 + p3 + p4),13:C2}");

            Console.ReadKey();
        }
    }
}
