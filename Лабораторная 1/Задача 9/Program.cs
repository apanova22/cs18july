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
            String cx, cy,r,fill;
            cx = Console.ReadLine();
            cy = Console.ReadLine();
            r = Console.ReadLine();
            fill = Console.ReadLine();
            
            Console.WriteLine(@"< circle cx = ""{0}"" cy = ""{1}"""+"\n"+@"r=""{2}"" fill=""{3}""/>", cx,cy,r,fill);
            
        }
    }
}
