using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
                return;
            }
            while(a<=n )
            {
                if (b > 3)
                {
                    b = 0;
                }
                Console.WriteLine(a+"-"+b);
            a = a + 1;
            b = b + 1;

        }
        
        }
    }
}
