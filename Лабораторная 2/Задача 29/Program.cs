using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8067;
            double mass = double.Parse(Console.ReadLine());
            double aDeg = double.Parse(Console.ReadLine());

            if (mass <= 0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            if (aDeg > 90)
            {
                Console.WriteLine("0");
                return;
            }

            double aRad = aDeg * Math.PI / 180;
            double force;
            force = mass * g * Math.Cos(aRad);
            Console.WriteLine("{0:F6}", force);
        }
    }
}
