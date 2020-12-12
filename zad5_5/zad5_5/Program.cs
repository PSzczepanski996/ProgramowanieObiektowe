using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5_5
{
    class Program
    {
        static void Rysuj(int dlugosc, int szerokosc, char znak)
        {
            for(int i=0; i<dlugosc; i++)
            {
                for(int j=0; j<szerokosc; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int dlugosc, szerokosc;
            char znak;
            Console.WriteLine("Podaj dlugosc: ");
            dlugosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc: ");
            szerokosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj znak: ");
            znak = Console.ReadKey(true).KeyChar;
            Rysuj(dlugosc, szerokosc, znak);
            Console.WriteLine();
            Rysuj(szerokosc, dlugosc, znak);
            Console.ReadKey();
        }
    }
}
