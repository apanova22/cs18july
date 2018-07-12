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
            double yDeg = double.Parse(Console.ReadLine());
            double yRad = yDeg * Math.PI / 180;
            double result;
            result =5* Math.Cos(yRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
