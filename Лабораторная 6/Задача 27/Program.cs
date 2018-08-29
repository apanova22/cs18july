using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y = int.Parse(Console.ReadLine());
            int a = 0;
            
            if (Y > 15 || Y < 0)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }
            while (a<15 )
            {
                if (a < Y)
                {
                    Console.Write("#");
                    a = a + 1;

                }
                else
                {
                    Console.Write(".");
                    a = a + 1;
                }
                
                
            }
        }
    }
}

