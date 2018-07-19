using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a= double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            if (a == 0 )
            {
                Console.WriteLine("Значение a должно быть не равно нулю");
                return;
            }
            if (d == 0)
            {
                Console.WriteLine("Значение d должно быть не равно нулю");
                return;
            }
            double R;
            R =(a*d+b*c)/(a*d) ;
            Console.WriteLine("{0:F4}", R);
        }
    }
}
