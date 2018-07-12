using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b > 0)
            {
                Console.WriteLine("Значение B должно быть не положительным");
                return;
            }
            double result;

            result = a * Math.Sqrt(-7*b);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
