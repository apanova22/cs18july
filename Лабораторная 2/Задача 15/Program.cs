using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
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
            double circumference;
            circumference = 2*Math.PI*radius;

            Console.WriteLine("{0:F4}", circumference);
        }
    }
}
