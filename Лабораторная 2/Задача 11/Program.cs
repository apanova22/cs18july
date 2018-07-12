using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDeg = double.Parse(Console.ReadLine());
            double bDeg = double.Parse(Console.ReadLine());
            double aRad = aDeg * Math.PI / 180;
            double bRad = bDeg * Math.PI / 180;
            double result;
            result = 3*Math.Sin(2 * aRad)*Math.Cos(3 * bRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
