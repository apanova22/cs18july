using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine(x * x);    
            }
            else
            {

                 Console.WriteLine(x);
            }
            if (y > 0)
            {
                Console.WriteLine(y * y);

            }
            else
            {

                Console.WriteLine(y);
            }
            if (z > 0)
            {
                Console.WriteLine(z * z);

            }
            else
            {

                Console.WriteLine(z);
            }
        }
    }
}
