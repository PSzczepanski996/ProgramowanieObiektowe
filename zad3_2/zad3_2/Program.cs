using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę: ");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź dzielnik: ");
            int dzielnik = int.Parse(Console.ReadLine());
            if (liczba % dzielnik == 0)
                Console.WriteLine("Liczba druga jest dzielnikiem!");
            else
                Console.WriteLine("Liczba druga nie jest dzielnikiem!");
            Console.ReadKey();
        }
    }
}
