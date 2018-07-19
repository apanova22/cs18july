using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_37
{
    class Program
    {
        static void Main(string[] args)
        {
            const double radius = 6350;
            double h = double.Parse(Console.ReadLine());
            if (h< 0)
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
                return;
            }

            double R;
            R =Math.Sqrt ((radius + h)*(radius + h) - radius* radius);
            Console.WriteLine("{0:F6}", R);
        }
    }
}
