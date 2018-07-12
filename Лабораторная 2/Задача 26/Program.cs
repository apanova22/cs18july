using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double acceleration = double.Parse(Console.ReadLine());
            if (initialVelocity < 0)
            {
                Console.WriteLine(" Начальная скорость должна быть неотрицательна");
                return;
            }
            if (time <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }
            
            double distance;
            distance = initialVelocity * time +((acceleration * Math.Pow(time,2))/2);
            Console.WriteLine("{0:F4}", distance);
        }
    }
}
