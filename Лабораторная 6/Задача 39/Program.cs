using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Program
    {
        static void Main(string[] args)
        {


            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int a = 0;
            int n = w;
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
            while (i < h)
            {
                while (a < w)
                {
                    if (a <n)
                    {
                        Console.Write("+");
                        a = a + 1;
                       

                    }
                    else
                    {
                        Console.Write("#");
                        a = a + 1;
                        
                    }
                    


                    if (a == w)
                    {
                        Console.WriteLine();
                    }
                   
                

                }
                n = n - 1;
                i = i + 1;
                a = 0;

                

            }
        }
    }
}
