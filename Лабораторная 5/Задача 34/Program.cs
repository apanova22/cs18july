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
            double x3 = x1 + w1;
            double x4 = x2 + w2;
            double y3 = y1 + h1;
            double y4 = y2 + h2;
            if (h1 <= 0 || h2 <= 0)
            {
                Console.WriteLine("Высота не должна быть отрицательной ");
                return;
            }
            if (x1 < x3 && x2 < x4)
            {
                if (x1 < x2)
                {
                    if (x3 < x2)
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                    if (x3 > x2 && x3 < x4)
                    {
                        Console.WriteLine("Пересекаются({0};{1})", x2, x3);
                    }
                    if (x3 > x4)
                    {
                        Console.WriteLine("Пересекаются({0};{1})", x2, x4);
                    }
                    return;
                }

                if (x1 >x2)
                {
                    if (x4 < x1)
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                    if (x4 > x1 && x4 > x3)
                    {
                        Console.WriteLine("Пересекаются({0};{1})", x1, x3);
                    }
                    if (x4 > x1 && x4 < x3)
                    {
                        Console.WriteLine("Пересекаются({0};{1})",x1, x4);
                    }

                }
            }
            else
            {
                Console.WriteLine("Значение А должно быть меньше В");
            }
        }
    }
}
