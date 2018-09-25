using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdacadbacdaabaadc";
            String x = Console.ReadLine();
            int xIndex = str.IndexOf(x);
            Console.WriteLine(xIndex);
            
          
            xIndex = str.IndexOf(x,xIndex+1);
            if (xIndex == -1)
            {

                return;
            }
            Console.WriteLine(xIndex);
        }
    }
}
