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
            int a = 100;
            int b = 500;
            Console.WriteLine("Ход решения:");
            Console.WriteLine("100");
            int i = 100;

            while (i<b)
            {
                
                i = i + 1;
                a = a + i;
Console.Write(a + " ");
            }
            Console.WriteLine("Ответ:"+a );
        }
    }
}
