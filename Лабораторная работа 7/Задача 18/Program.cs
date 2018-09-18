using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] c = { "11", "13", "17", "19", "10", "12","14", "15", "16", "18", "20" };
            String x = Console.ReadLine();
            int i = 0;
            while (i < c.Length)
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
