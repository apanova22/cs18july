using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double x = double.Parse(Console.ReadLine());
           
            if((x - 5) < 0 )
                {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
           
            double R;   
            R = ( Math.Sqrt(x+5)+Math.Sqrt(x-5))/(2*Math.Sqrt(x));
            Console.WriteLine("{0:F6}", R);
        }
    }
}
