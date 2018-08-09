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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Координата Х должна быть неотрицательна");
                return;
            }
            if (y < 0)
            {
                Console.WriteLine( "Координата У должна быть неотрицательна" );
                return;
            }
            if (x >= 100 && x <= 190)
            {
                if (y <= 170 && y >= 100)
                {
                    Console.WriteLine("Точка внутри");

                }
                else
                {
                    Console.WriteLine("Точка снаружи");
                }
            }
            else
            {
                Console.WriteLine("Точка снаружи");
            }

        }
    }
}
