using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsjusz;
            Console.Write("Podaj celsjusze: ");
            celsjusz = double.Parse(Console.ReadLine());
            Console.Write("Twój wynik to: ");
            Console.WriteLine(32 + (9.0/5) * celsjusz);
            Console.ReadKey();
        }
    }
}
