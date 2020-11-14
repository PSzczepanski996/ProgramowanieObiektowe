using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, wzrost;
            Console.Write("Podaj masę: ");
            masa = double.Parse(Console.ReadLine());
            Console.Write("Podaj wzrost: ");
            wzrost = double.Parse(Console.ReadLine());
            double BMI = masa / Math.Pow(wzrost / 100.0, 2);
            Console.Write("BMI: ");
            Console.WriteLine(BMI);
            if(BMI < 16) {
                Console.WriteLine("Wygłodzenie");
            } else if(BMI >= 16 && BMI <= 16.99){
                Console.WriteLine("Wychudzenie");
            } else if (BMI >= 17 && BMI <= 18.49){
                Console.WriteLine("Niedowaga");
            } else if (BMI >= 18.5 && BMI <= 24.99){
                Console.WriteLine("Pożądana masa ciała");
            } else if (BMI >= 25 && BMI <= 29.99){
                Console.WriteLine("Nadwaga");
            } else if (BMI >= 30 && BMI <= 34.99){
                Console.WriteLine("Otyłość 1 stopnia");
            } else if (BMI >= 35.0 && BMI <= 39.99){
                Console.WriteLine("Otyłość 2 stopnia (duża)");
            } else if (BMI >= 40){
                Console.WriteLine("Otyłość 3 stopnia (chorobliwa)");
            }
            Console.ReadKey();
        }
    }
}
