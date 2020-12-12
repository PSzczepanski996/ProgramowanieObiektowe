using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5_2
{
    class Program
    {
        static bool sprawdzPrzedzial(int a, int b, int x)
        {
            return x > a && x < b;
        }
        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sprawdzPrzedzial(a, b, x));
            Console.ReadKey();
        }
    }
}
