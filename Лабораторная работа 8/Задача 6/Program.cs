using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefwxyz";
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            bool isXinStr = str.Contains(x);
            bool isYinStr = str.Contains(y);
            if (isXinStr == false)
            {
                Console.WriteLine("Значение x отсутствует в строке");
                return;
            }
            if (isYinStr == false)
            {
                Console.WriteLine("Значение y отсутствует в строке");
                return;
            }

            int xIndex = str.IndexOf(x);
            int yIndex = str.IndexOf(y);
            if (xIndex < yIndex)
            {
                String part = str.Substring(xIndex+1, yIndex-xIndex - 1);
                Console.WriteLine(part);
                
            }
            else
            {
                String part = str.Substring(yIndex + 1, xIndex - yIndex - 1);
                Console.WriteLine(part);
            }
           
            
        }
    }
}
