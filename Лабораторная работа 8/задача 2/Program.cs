using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefwxyz";
            String x = Console.ReadLine();
            int xIndex = str.IndexOf(x);
            Console.WriteLine(str.Length - xIndex-1);
        }
    }
}
