using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double r1 = double.Parse(Console.ReadLine());
            double r2 = double.Parse(Console.ReadLine());
            
            if (r1 == 0)
            {
                Console.WriteLine("Значение r1 должно быть не равно нулю");
                return;
            }
            if (r2 == 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");
                return;
            }
            
            
            double result;
            result = 1 / r1 + 1 / r2;
            Console.WriteLine("{0:F4}", result);
        }
    }
}
