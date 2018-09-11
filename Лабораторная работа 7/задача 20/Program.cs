using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            String data1 = Console.ReadLine();
            String[] top = data1.Split(' ');
            String data2 = Console.ReadLine();
            String[] left = data2.Split(' ');
            int i = 0;
            int p = 0;
            int n= 0;
            int m = 0;
            Console.Write(" ");
            while (i<top.Length)
            {
Console.Write(top[i]);
                i++;

            }
            Console.WriteLine();
            while (n < left.Length)
            {
                i = 0;
                
                Console.Write(left[m]);
                while (i < top.Length)
                {
                    if (top[i].Equals(left[m]))
                    {
                        Console.Write( "+");
                       
                    }
                    else
                    {
                        Console.Write(" ");
                       
                    }
 
                    i++;
                }
m++;
               
                n++;
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write(" ");
            while(p<top.Length)
            {
                Console.Write("-");
                p++;
            }
        }
    }
}
