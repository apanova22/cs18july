using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_34
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int a = 0;
            int i = 0;
            if (w < 0 )
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            while (i<h)
            {
                while (a < w)
                {

                    Console.Write(s);
                    a = a + 1;
                    if (a == w)
                    {
                        Console.WriteLine();
                    }

                        
                }
                i = i + 1;
                a = 0;
                
               
                
                
                
            }

            
        }
    }
}
