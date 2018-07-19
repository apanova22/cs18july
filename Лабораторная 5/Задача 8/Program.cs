using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);

            }
            else if (d == 0)
            {
                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 один корень", a, b, c);
            }
            else
            {

                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
            }

        }
    }
}
