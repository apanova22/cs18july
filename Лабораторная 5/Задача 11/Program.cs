using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            if (a<b)
            {
                if (b < c)
                {
                    Console.WriteLine("Выполняется");
                }
                else
                {
                    Console.WriteLine("Не выполняется");
                }
            }
            if (a>=b)
            {
                Console.WriteLine("Не выполняется");
                return;
            }
           

        }
    }
}
