using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] c = { "a", "b", "c" };
            String x = Console.ReadLine();
            int i = 0;
            while (i<c.Length)
            {
                if (c[i].Equals(x))
                {
                    Console.WriteLine(c[i] + "+");
                }
                else
                {
                    Console.WriteLine(c[i]);
                }
                i++;
            }
        }
    }
}
