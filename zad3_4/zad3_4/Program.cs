using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double l_liczba;
            double r_liczba;
            char OP;
            Console.WriteLine("Podaj 1 liczbę: ");
            l_liczba = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbę: ");
            r_liczba = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj operator: ");
            OP = Console.ReadKey().KeyChar;
            if (OP == '+')
                Console.WriteLine(l_liczba + r_liczba);
            else if (OP == '-')
                Console.WriteLine(l_liczba - r_liczba);
            else if (OP == '*')
                Console.WriteLine(l_liczba * r_liczba);
            else if (OP == '/')
                Console.WriteLine(l_liczba / r_liczba);
            Console.ReadKey();
        }
    }
}
