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
            int w = int.Parse(Console.ReadLine());
            int n=-1;
            int i = 0;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0;20]");
                return;
            }
            while (n<9)
            {
                //1
                    n = n + 1;

                while (i<w)
                {
                    //2
                    i = i + 1;
                    Console.Write(n);
                }
                //4
                i = 0;
                Console.WriteLine();
                

            }
            //5
            Console.WriteLine();
        }
    }
}
