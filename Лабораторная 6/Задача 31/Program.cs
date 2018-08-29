using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int a = 1;
            int count = 0;
            if (y < 0)
            {
                Console.WriteLine("Значение Y должно быть положительным");
                return;
            }
            while (a <= y)
            {
                if (y % a == 0)
                {
                    count = count + 1;
                    a = a + 1;
                }
                else
                {
                    
                    a = a + 1;
                }

            }
            if (count ==2 )
            {
                Console.WriteLine("простое");
            }
            else
            {
                Console.WriteLine("непростое");
            }
        }
    }
}
