using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }
            if ((x-x1)/(x2-x1)==(y-y1)/(y2-y1))
            {
                
                    Console.WriteLine("Точка принадлежит прямой");
               
            }
            else
            {
                Console.WriteLine("Точка не принадлежит прямой");
               
            }
        }
    }
}
