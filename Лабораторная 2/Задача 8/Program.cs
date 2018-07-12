using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double xDeg = double.Parse(Console.ReadLine());
            double xRad = xDeg * Math.PI / 180;
            double result;
            result = Math.Sin(xRad);
            Console.WriteLine("{0:F4}",result);
        }
    }
}
