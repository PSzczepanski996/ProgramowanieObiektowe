using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5_4
{
    class Program
    {
        static int[] mnozTablice(int[] tablica, int mnoznik)
        {
            for(int i=0; i<tablica.Length; i++)
            {
                tablica[i] *= mnoznik;
            }
            return tablica;
        }
        static void Main(string[] args)
        {
            int[] table = new int[] { 1, 3, 5, 7, 9 };
            table = mnozTablice(table, 3);
            for(int i=0; i<table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
            Console.ReadKey();
        }
    }
}
