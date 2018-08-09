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
            double n = double.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Значение N должно быть положительным");
                return;
            }

            double s = 0;
            double a = 1;
            double b;
            while(a<=n)
            {
                
                 b = 1 / a;
                a = a + 1;
                s = s+b;
            }
 Console.WriteLine("{0:F4}",s);
        }
    }
}
