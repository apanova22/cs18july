using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefwxyz";
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x>y)
            {
                Console.WriteLine("Значение x должно быть меньше y");
                return;
            }
            if (x < 0 || x >= str.Length)
            {
                Console.WriteLine("Значение x должно быть в интервале [0,длина строки)");
                return;
            }
            if (y < 0 || y >= str.Length)
            {
                Console.WriteLine("Значение y должно быть в интервале [0,длина строки)");
                return;
            }
            String part = str.Substring(x, y-x+1);
            Console.WriteLine(part);
        }
    }
}
