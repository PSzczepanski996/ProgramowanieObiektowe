using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            double delta = (b * b) - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Równanie kwadratowe ma dwa rozwiązania: ");
                Console.WriteLine((-b - Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine((-b + Math.Sqrt(delta)) / 2 * a);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Równanie kwadratowe ma jedno rozwiązanie: ");
                Console.WriteLine((-b) / 2 * a);
            }
            else
            {
                Console.WriteLine("Równanie kwadratowe nie ma rozwiązań! ");
            }
            Console.ReadKey();
        }
    }
}
