using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g= 9.8067;
            double mass1 = double.Parse(Console.ReadLine());
            double mass2 = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            if (mass1 <= 0 || mass2 <=0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            if (distance <= 0)
            {
                Console.WriteLine("Дистанция должна быть положительной");
                return;
            }


            double force;
            force = g*((mass1*mass2)/(distance*distance));
            Console.WriteLine("{0:F4}", force);
        }
    }
}
