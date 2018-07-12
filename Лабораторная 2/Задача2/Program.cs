using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double A;
            A = double.Parse(a);

            Console.WriteLine("{0:F4}", A);

        }
    }
}
