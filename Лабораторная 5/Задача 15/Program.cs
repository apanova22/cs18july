using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x>-3 && x<5)
            {

                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine();
            }
            if (y > -3 && y < 5)
            {

                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine();
            }
            if (z > -3 && z < 5)
            {

                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}
