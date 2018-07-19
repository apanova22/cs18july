using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCircle = double.Parse(Console.ReadLine());
            double areaSquare = double.Parse(Console.ReadLine());

            if (areaCircle < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            if (areaSquare < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положителньой");
                return;
            }
            double r = Math.Sqrt(areaCircle / Math.PI);
            double d = 2 * r;
            double a = Math.Sqrt(areaSquare);
            if (a > d)
            {
                Console.WriteLine("Круг уместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }
        }
    }
}
