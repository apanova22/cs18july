using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            if (A < -10)

            {
                Console.WriteLine("Значение A должно быть в интервале [-10, 100]");
                return;
            }
            if (A > 100)
            {
                Console.WriteLine("Значение A должно быть в интервале [-10, 100]");
                return;
            }
            if (A > 10 && A < 20)
            {
                Console.WriteLine(A+"'ый");
                return;
            }
            
            if (A % 10 == 3)
            {
                Console.WriteLine(A+"'ий");
                return;
            }
            if (A % 10 == 2 || A % 10 == 6 || A % 10 == 7 || A % 10 == 8 || A == 0 || A == 40)
            {
                Console.WriteLine(A + "'ой");
            }
            else
            {
                Console.WriteLine(A+"'ый");
            }
        }
    }
}
