using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Уравнение y={0}x^2+{1}x+{2} не является квадратным",a,b,c);
                return;
            }


            
            double discriminant;
            discriminant = b * b - 4 * a * c;
            Console.WriteLine("{0:F4}", discriminant);
        }
    }
}
