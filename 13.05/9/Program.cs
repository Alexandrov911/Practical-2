using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.д
            Console.WriteLine("введите число r1");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число r2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double a = (1 / r1) + (1 / r2);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
