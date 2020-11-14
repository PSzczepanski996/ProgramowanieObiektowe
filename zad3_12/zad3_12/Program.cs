using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 0;
            int suma = 0;
            do {
                liczba = Convert.ToInt32(Console.ReadLine());
                suma += liczba;
            } while (liczba != 0);
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
