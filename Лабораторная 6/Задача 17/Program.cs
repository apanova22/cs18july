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
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Значение N должно быть положительным");
                return;
            }

            int s = 0;
            int a = 1;
            int b;
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
