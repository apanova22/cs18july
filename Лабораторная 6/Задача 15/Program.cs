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
            int a;
            a = int.Parse(Console.ReadLine());
            int b;
            b = int.Parse(Console.ReadLine());
            
            long p = 1;
            if (a < b)
            {
                while (a <= b)
                {
                    p = p * a;

                    a = a + 1;




                }
            }
            else
            {
                while (b <= a)
                {
                    p = p * b;

                    b = b + 1;




                }
            }
            
            Console.WriteLine("произведение" + p);
        }
    }
}
