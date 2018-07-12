using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDeg = double.Parse(Console.ReadLine());
           
            double aRad;
            aRad = aDeg*Math.PI/180;
            Console.WriteLine("{0:F4}", aRad);
        
    }
    }
}
