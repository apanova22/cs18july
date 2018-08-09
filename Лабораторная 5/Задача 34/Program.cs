using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            double w1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());
            double w2 = double.Parse(Console.ReadLine());
            if (h1 <= 0 || h2 <= 0)
            {
                Console.WriteLine("Высота не должна быть отрицательной ");
                return;
            }
            if (((y1 + h1) < (y2 + h2) || (y1 + h1) > (y2 + h2) || (x1 + w1) < (x2 + w2) || (x1 + w1) > (x2 + w2)))
                {
                Console.WriteLine("Пересекаются");

            }
            else
            {
                Console.WriteLine("Не пересекаются ");
            }
        }
    }
}
