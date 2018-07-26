using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int w=int.Parse(Console.ReadLine());
            
            int i = 0;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0;20]");
                return;
            }
            while (i < w)
            {
                
                Console.Write("a");

               
                i = i + 1;

            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("b");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("c");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("d");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("e");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("f");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("g");
                i = i + 1;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("h");
                i = i + 1;
            }


        }
    }
}
