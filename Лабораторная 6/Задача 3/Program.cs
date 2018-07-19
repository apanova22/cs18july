using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A=double.Parse(Console.ReadLine());
            double B=double.Parse(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
            }
            while (A <= B)
            {
                Console.WriteLine( A);
                A = A + 1;
            }
        }
    }
}
