using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            if (P == 0)
            {
                Console.WriteLine("Значение P не должно быть равно нулю");
                return;
            }
            if (M % P == 0)
            {
                Console.WriteLine(M / P);
            }
            else
            {
                Console.WriteLine("  M не делится нацело на P " );
            }

        }
    }
}
