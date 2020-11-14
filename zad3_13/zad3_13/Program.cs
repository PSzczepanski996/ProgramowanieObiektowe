using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
            bool switcher = false;
            int suma = 0;
            for(int i = 0; i <= liczba; i++) {
                if (switcher == false) suma -= i;
                else suma += i;
                switcher = !switcher;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
