using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            long silnia = 1;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToUInt32(Console.ReadLine());
            for(uint i=n; i>1; i--) {
                silnia *= i;
            }

            Console.WriteLine("Silnia wynosi: ");
            Console.WriteLine(silnia);
            Console.ReadKey();
        }
    }
}
