using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            bool wynik;
            x = 1;
            y = 4;
            z = 2;
            wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            x = 1;
            y = 4;
            z = 2;
            wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            x = 1;
            y = 4;
            z = 2;
            wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            x = 1;
            y = 4;
            z = 2;
            wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            x = 1;
            y = 4;
            z = 2;
            wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            x = 1;
            y = 4;
            z = 2;
            wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
        }
    }
}
