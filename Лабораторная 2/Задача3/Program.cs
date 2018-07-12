using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            x = Console.ReadLine();
            double A;
            A = double.Parse(x);
            A = A + 7;
            Console.WriteLine("{0:F4}",  A);
        }
    }
}
