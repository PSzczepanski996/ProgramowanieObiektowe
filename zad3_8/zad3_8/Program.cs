using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj średnią ocen: ");
            double sredniaOcen = Convert.ToDouble(Console.ReadLine());
            if(sredniaOcen >= 2.00 && sredniaOcen < 3.99) {
                Console.WriteLine("Nie należy Ci się stypendium.");
            } else if(sredniaOcen >= 4.00 && sredniaOcen <= 4.79) {
                Console.WriteLine("Należy Ci się 350zł stypendium.");
            } else if(sredniaOcen > 4.80 && sredniaOcen <= 5.00) {
                Console.WriteLine("Należy Ci się 550zł stypendium.");
            }
            Console.ReadKey();
        }
    }
}
