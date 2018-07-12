using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                a = a - a - a;

            }
            Console.WriteLine(a);
        }
    }
}
