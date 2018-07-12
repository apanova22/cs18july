using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            if ((x + Math.Sqrt(y))<0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double result;

            result = -5 * Math.Sqrt(x+Math.Sqrt(y));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
