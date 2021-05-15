using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.з
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            double z = (b * b) - (4 * a * c);
            Console.WriteLine(z);
            Console.ReadKey();

        }
    }
}
