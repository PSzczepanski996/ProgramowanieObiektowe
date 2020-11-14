using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int wartosc = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 100; i++) {
                if((100 - wartosc * i) > 0)
                    Console.WriteLine("Brakuje " + (100-wartosc*i) + " wartosci " + i + " zeby przekroczyc liczbe 100");
            }
            Console.ReadKey();
        }
    }
}
