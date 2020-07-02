using System;
using System.Numerics;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления вероятности определеного количества попаданий при выстрелах");
            Console.WriteLine("Введите количество выстрелов по мишени ");

            double kolvo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вероятность попадания при каждом выстреле");
            double ver = Convert.ToDouble(Console.ReadLine());


            double promax = 1 - ver;
            int y = 2;
           
            Console.WriteLine("Вероятность промаха при выстреле {0}", promax);
            Console.WriteLine("Количество нужных попаданий при выстреле    ");
            double popad = Convert.ToDouble(Console.ReadLine());


            double pervfact = Factorial(popad);
            double vtorfact = Factorial(kolvo);
            double trifact =Factorial( kolvo - popad);

            double veroyntost = vtorfact / (pervfact * trifact)*Math.Pow(ver,popad)*Math.Pow(promax,kolvo-popad);
            double rez =Math.Round(veroyntost,y)*100;
            Console.WriteLine("Вероятность нужного количества попаданий {0} ",rez+" % ");

        }
         public static double Factorial(double kak)
        {
            double n = kak;  
            int factorial = 1;   

            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
