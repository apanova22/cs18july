using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 1;
            if (x < 0)
            {
                Console.WriteLine("Значение X должно быть положительным");
                return;
            }
            while (a<=x)
            {
                if (x % a == 0)
                {
                    Console.Write(a+" ");
                    a = a + 1;
                }
                else
                {
                   
                    a = a + 1;
                }
                
 
            }
            
        }
    }
}
