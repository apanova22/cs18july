using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double k = double.Parse(Console.ReadLine());
            double a;
            if (k > 0)
            {
                a=Math.Sqrt(k);
                Console.WriteLine(a);
                
            }
            else
            {
                a = k * k;
                Console.WriteLine(a);
            }
            
        }
    }
}
