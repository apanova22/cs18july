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
            String str = Console.ReadLine();

            if (str[0] == 's')
            {
                string x=str.ToLower();
                Console.WriteLine(x);
            }
            else if (str[0] == 'U')
            {
                string y=str.ToUpper();
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(str);
            }

        }
    }
}
