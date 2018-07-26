using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            if (a < 0 )
            {
                Console.WriteLine("Значение a должно быть неотрицательным");
                return;
            }
            if ( b < 0 )
            {
                Console.WriteLine("Значение b  должно быть неотрицательным");
                return;
            }
            if ( c < 0 )
            {
                Console.WriteLine("Значение c должно быть неотрицательным");
                return;
            }
            if (d < 0)
            {
                Console.WriteLine("Значение d должно быть неотрицательным");
                return;
            }
            if (a < c && b < d)
            {
                Console.WriteLine("Размещение возможно");
            }
            else
            {
                Console.WriteLine("Размещение невозможно ");
            }

        }
    }
}
