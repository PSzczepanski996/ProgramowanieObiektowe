using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź rok:");
            int rok = int.Parse(Console.ReadLine());
            if ((rok % 4) == 0 && ((rok % 100) != 0) || (rok % 400) == 0)
                Console.WriteLine("Rok przestępny");
            else
                Console.WriteLine("Rok nieprzestępny");
            Console.ReadKey();
        }
    }
}
