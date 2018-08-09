using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            if (A < -100 || A > 500)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
                return;
            }
            int i = 0;
            while (A <= 500)
            {
                i = i + A;
                A = A + 1;


            }
            Console.WriteLine(i);
        }
    }
}
