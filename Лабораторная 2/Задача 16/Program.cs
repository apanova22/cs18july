using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
                return;
            }
            double volume;
            volume = 4*Math.PI*Math.Pow(radius,3)/ 3;

            Console.WriteLine("{0:F4}", volume);
        }
    }
}
