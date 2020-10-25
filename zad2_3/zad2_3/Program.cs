using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, wzrost;
            Console.Write("Podaj masę: ");
            masa = double.Parse(Console.ReadLine());
            Console.Write("Podaj wzrost");
            wzrost = double.Parse(Console.ReadLine());
            Console.Write("BMI: ");
            Console.WriteLine(masa / (wzrost * wzrost));
            Console.ReadKey();
        }
    }
}
