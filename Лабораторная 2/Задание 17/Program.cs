using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            if (x <0)
            {
                Console.WriteLine("Значение x должно быть не отрицательным");
                return;
            }
            double result;
            
            result = Math.Sqrt(x);
            Console.WriteLine(result);
        }
    }
}
