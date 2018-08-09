using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int sl = 0;
            int sp = 0;
            while (a>=199 || a<=83)
            {
                  
                if (a <= 83)
                {
                    sl = sl + 1;
                }
                else if (a >= 199)
                {
                    sp = sp + 1;
                }
                else
                {
                    Console.WriteLine(" ");
                } 
               a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Количество слева: {0}, количество справа: {1}",sl,sp);
        }
    }
}
