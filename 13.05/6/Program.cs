using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.б
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a");
            double c = Convert.ToDouble(Console.ReadLine());
            double t = a / (b * c);
            Console.WriteLine(t);
            Console.ReadKey();

        }
    }
}
