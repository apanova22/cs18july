using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine("Второе");
            }
            else if (b == a)
            {
                Console.WriteLine("Числа равны"); 
            }
            else
            {
                Console.WriteLine("Первое");
            }

        }
    }
}
