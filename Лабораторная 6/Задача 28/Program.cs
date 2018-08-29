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
            int a = 100 ;
            int b = 0;
            Console.WriteLine("Ход решения:");
            while (a <= 1000)
            {
                if (a % 13 == 0)
                {
                    Console.Write("{0}+", a);
                    b = b + 1;
                    a = a + 1;
                }
                else
                {
                    Console.Write(a + " ");
                       a = a + 1;
                }

                
              
            }
            
            Console.WriteLine("Ответ:{0}", b);
        }
    }
}
