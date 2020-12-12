using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] table = new int[n];
            for (int i = 0; i < n; i++)
            {
                table[i] = Convert.ToInt32(Console.ReadLine());
            }
            int wartoscNajmniejsza = int.MaxValue;
            int wartoscNajwieksza = int.MinValue;
            int suma = 0;
            int iloscDodatnich = 0;
            int indexMin = 0;
            int indexMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (table[i] > wartoscNajwieksza){
                    indexMax = i;
                    wartoscNajwieksza = table[i];
                }
                if (table[i] < wartoscNajmniejsza){
                    indexMin = i;
                    wartoscNajmniejsza = table[i];
                }
                if (table[i] > 0) iloscDodatnich++;
                suma += table[i];
            }
            Console.WriteLine("Wartosc najmniejszego elementu: " + table[indexMin] + " Indeks: " + indexMin);
            Console.WriteLine("Wartosc najwiekszego elementu: " + table[indexMax] + " Indeks: " + indexMax);
            Console.WriteLine("Srednia: " + suma / n);
            Console.WriteLine("Ilosc dodatnich elementow tablicy: " + iloscDodatnich);
            Console.ReadKey();
        }
    }
}
