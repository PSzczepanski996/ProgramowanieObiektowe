using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int wiersze = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= wiersze; i++) {
                for(int j = 0; j < i; j++){
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = wiersze; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i <= wiersze; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1) Console.Write('*');
                    else Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
