using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double edge = double.Parse(Console.ReadLine());
            if (edge<=0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            double area;
            area = 6 * edge * edge;
            area = 6 * Math.Pow(edge, 2);
            Console.WriteLine(area);
        }
    }
}
