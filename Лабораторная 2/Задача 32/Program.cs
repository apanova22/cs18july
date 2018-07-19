using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double cInDeg = double.Parse(Console.ReadLine());
            double cInRad;
            cInRad = cInDeg * Math.PI / 180;
            double result;
            result = Math.Sqrt(a*a+b*b- 2*a*b*Math.Cos(cInRad));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
