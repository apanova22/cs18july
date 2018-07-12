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
            String x = Console.ReadLine();
            if (x == "a")
            {
                Console.WriteLine("a+bcd");

            }
            if (x == "b")
            {
                Console.WriteLine("ab+cd");

            }
            if (x == "c")
            {
                Console.WriteLine("abc+d");
            }
            if (x == "d")
            {
                Console.WriteLine("abcd+");
            }

            if (x != "a" && x != "b" && x != "c" && x != "d")
            {
                Console.WriteLine("abcd");
            }
        }
    }
}
