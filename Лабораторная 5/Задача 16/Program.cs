using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            if (A <= 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (B <= 0)
            {
                Console.WriteLine("Значение В должно быть неотрицательным");
                return;
            }
            if (C <= 0)
            {
                Console.WriteLine("Значение С должно быть неотрицательным");
                return;
            }
            if (A == B || A == C || B == C)
            {

                Console.WriteLine("Треугольник является равнобедренным");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным");
            }

        }
    }
}
