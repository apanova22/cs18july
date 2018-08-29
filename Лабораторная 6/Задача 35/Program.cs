using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_35
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int w = int.Parse(Console.ReadLine());

            int a = w - 2;
            int i = 0;
            if (w == 0)
            {
                return;
            }
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            Console.Write("+");
            while (i<a)
            {
                Console.Write("-");
                i++;
            }
            Console.WriteLine("+");
            i = 0;
            Console.Write("|");
            while (i < a)
            {
                Console.Write(".");
                i++;
            }
            Console.WriteLine("|");
            i = 0;
            Console.Write("+");
            while (i < a)
            {
                Console.Write("-");
                i++;
            }
            Console.WriteLine("+");


        }
    }
}
