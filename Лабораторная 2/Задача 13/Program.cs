using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Значение base должно быть положительным");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine("Значение  height должно быть положительным");
                return;
            }
            double area;
            area = b* height/2;
          
            Console.WriteLine(area);
        }
    }
}
