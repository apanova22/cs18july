using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x > y && x >z)
            {
                Console.WriteLine(x);
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine(y);
                }
                else
                {
                    Console.WriteLine(z);
                }
            }
        }
    }
}
