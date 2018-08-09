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
            int B = int.Parse(Console.ReadLine());
            if (B < -10 || B > 10000)
            {
                Console.WriteLine("Значение B должно быть в интервале [-10, 10000]");
                return;
            }
            int i = 0;
            while (-10<=B)
            {
                i = i + B;
                B = B - 1;


            }
            Console.WriteLine(i);
        }
    }
}
