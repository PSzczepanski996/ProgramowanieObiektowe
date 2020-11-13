using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę1: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź liczbę2: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź liczbę3: ");
            int liczba3 = int.Parse(Console.ReadLine());
            if ((liczba1 > liczba2) && (liczba1 > liczba3))
                Console.WriteLine(liczba1);
            else if ((liczba2 > liczba1) && (liczba2 > liczba3))
                Console.WriteLine(liczba2);
            else if ((liczba3 > liczba1) && (liczba3 > liczba2))
                Console.WriteLine(liczba3);
            Console.ReadKey();
        }
    }
}
