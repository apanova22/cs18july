using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_37
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int h = int.Parse(Console.ReadLine());
            int i=0;
            int n = 1;
            if (h < 0)
            {
                Console.WriteLine("Значение Н должно быть неотрицательно");
                return;
            }
            while(n<=h)
            {
                while(i<n)
            {
                Console.Write(s);
                i = i + 1;
              
            }
            Console.WriteLine();
            i = 0;
            n = n+1;
            }
            //while(i<n)
            //{
            //    Console.Write(s);
            //    i = i + 1;
              
            //}
            //Console.WriteLine();
            //i = 0;
            //n = n+1;
            //while (i < n)
            //{
            //    Console.Write(s);
            //    i = i + 1;
                

            //}
            //Console.WriteLine();
            //i = 0;
            //n = n + 1;
            //while (i < n)
            //{
            //    Console.Write(s);
            //    i = i + 1;
                

            //}
            //Console.WriteLine();
            //i = 0;
            //n = n + 1;
            //while (i < n)
            //{
            //    Console.Write(s);
            //    i = i + 1;
               

            //}


        }
    }
}
