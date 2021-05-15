using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.ж
            Console.WriteLine("введите число r");
            double r = Convert.ToDouble(Console.ReadLine());
            double b = 2 * 3.14 * r;
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
