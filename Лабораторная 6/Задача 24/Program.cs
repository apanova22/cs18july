using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_24
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
            while (a < n)
            {
                if (b > 4)
                {
                    Console.Write(" ");
                    b = 0;
                }
                Console.Write("!");
                a = a + 1;
                b = b + 1;
            }
        }
    }
}

