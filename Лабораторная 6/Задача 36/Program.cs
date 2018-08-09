using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Program
    {
        static void Main(string[] args)
        {
           //0123456
//0
//...
//|
//-------
          //  0123456
//0...|
//-------
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int n = 0;
Console.Write(" ");
            while (i < w)
            {
                
                Console.Write(i);
                i = i + 1;
            }
            Console.WriteLine("");
            i = 0;
            while (n < h)
            {

                Console.Write(n);
                i = 0;
                while (i < w)
                {
                    Console.Write(".");
                    i = i + 1;
                }
              
                n = n + 1;
Console.Write("|");
Console.WriteLine();
            }
            
            i = 0;
Console.Write(" ");
            while (i < w)
            {
                
                Console.Write("-");
                i = i + 1;
            }

        }
    }
}
