using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ход решения:");

            int i = 0;
            int a = 20;

            while (a <= 40)
            {
                Console.Write(i);
                i = i + a * a * a;

                Console.Write("+ " + a * a * a + "=");
                a = a + 1;
            }
            Console.WriteLine("Ответ:" + i);
        }
    }
}
