using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] c = { "a", "b", "c" ,"d","e","f","g","h"};
            String x = Console.ReadLine();
            int i = 0;
            while (i < c.Length)
            {
                if (c[i].Equals(x))
                {
                    Console.Write(c[i]);
                    return;
                }
                else
                {
                    Console.Write(c[i]);
                }
                i++;
            }
        }
    }
}
