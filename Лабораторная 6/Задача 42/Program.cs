using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_42
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int n = 0;
            if (h < 0)
            {
                Console.WriteLine("Значение Н должно быть неотрицательно");
                return;
            }
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            while (n < h)
            {
                if (n % 2 == 0)
                {
                    while (i < w)
                    {
                        Console.Write(s1);
                        i = i + 1;

                    }
                    Console.WriteLine();
                    i = 0;
                }


                else
                {
                    while (i < w)
                    {
                        Console.Write(s2);
                        i = i + 1;
                    }
                    Console.WriteLine();
                }
                i = 0;
                n = n + 1;
            }
        }
    }
}

