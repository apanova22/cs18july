using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xa = double.Parse(Console.ReadLine());
            double Ya = double.Parse(Console.ReadLine());
            double Xb = double.Parse(Console.ReadLine());
            double Yb = double.Parse(Console.ReadLine());
           
            double AB;
            AB = Math.Sqrt(((Xb - Xa) * (Xb - Xa))+((Yb - Ya)*(Yb - Ya)));
            Console.WriteLine("{0:F4}", AB);
        }
    }
}
