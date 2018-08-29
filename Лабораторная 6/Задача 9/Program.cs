using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 9)
            {
                Console.WriteLine("{0}*" + "{1}=" + i * V,i,V);
                i = i + 1;
            }
        }
    }
}
