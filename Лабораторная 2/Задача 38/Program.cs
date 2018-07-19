using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_38
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
           

            double R;
            R = Math.Sqrt(x2*x2 + x1*x1);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
