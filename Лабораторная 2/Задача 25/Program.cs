using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocity1 = double.Parse(Console.ReadLine());
            double velocity2 = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            if (velocity1 <0 )
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            if (velocity1 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            if (distance<0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательна");
                return;
            }
            double time;
            time = distance/(velocity1+ velocity2);
            Console.WriteLine("{0:F4}", time);
        }
    }
}
