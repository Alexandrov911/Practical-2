using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.д
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Abs(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
