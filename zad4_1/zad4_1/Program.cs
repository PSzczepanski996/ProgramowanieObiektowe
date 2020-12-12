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
            for(int i=0; i<n; i++){
                table[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<n; i++){
                Console.WriteLine(table[i]);
            }
            Console.ReadKey();
        }
    }
}
