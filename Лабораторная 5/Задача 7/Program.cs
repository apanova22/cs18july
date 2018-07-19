using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double edge = double.Parse(Console.ReadLine());
            if (radius < 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
                return;
            }
            if (edge < 0)
            {
                Console.WriteLine("Сторона квадрата должна быть положительна");
                return;
            }
            double Skvadrat;
            Skvadrat = edge * edge;
            double Skrug;
            Skrug=Math.PI* radius*radius;
            if (Skvadrat > Skrug)
            {
                Console.WriteLine("Площадь квадрата {0:F4} больше площади круга {1:F4}", Skvadrat,Skrug);
                
            }
            else
            {
                Console.WriteLine("Площадь круга {1:F4} больше площади квадрата {0:F4}", Skvadrat, Skrug);
            }




        }
    }
}
