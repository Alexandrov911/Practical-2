using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.1 1-Вариант 
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c1");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число d");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число d1");
            double d1 = Convert.ToDouble(Console.ReadLine());
            double f = Math.Sqrt((a - a1) + (b - b1))* ((a - a1) + (b - b1));
            double g = Math.Sqrt((b - b1) + (c - c1)) * ((b - b1) + (c - c1));
            double v = Math.Sqrt((c - c1) + (d - d1)) * ((c - c1) + (d - d1));
            double m = Math.Sqrt((d - d1) + (a - a1)) * ((d - d1) + (a - a1));
            double s = f + g + v + m;
            Console.WriteLine(s);
            Console.ReadKey();



        }
    }
}
