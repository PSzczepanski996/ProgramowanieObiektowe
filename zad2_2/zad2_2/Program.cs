using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Wynik:");
            Console.WriteLine((b * b) - 4 * a * c);
            Console.ReadKey();
        }
    }
}
