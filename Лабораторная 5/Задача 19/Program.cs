using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int A = int.Parse(Console.ReadLine());
           if(A>9999)
            {
                Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
                return;
            }
            if (A < 1000)

            {
                Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
                return;
            }
            int a = A / 1000;
            int b = A % 1000 / 100;
            int c = A % 1000 % 100 / 10;
            int d = A % 1000 % 100 % 10;
            if (b == d)
            {
                Console.WriteLine("Равно");
            }
            else
            {
                Console.WriteLine("Не равно");
            }
        }
    }
}
