using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_35
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            if (Math.Sqrt(a * x * x + b * x + c)==0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            if ((a * x * x + b * x + c)<0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double R;
            R = 1/Math.Sqrt(a*x*x+b*x+c);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
