using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int x = int.Parse(Console.ReadLine());
                int a = 30;
                while (a <= 40)
                {
                    if (x == a)
                    {
                        Console.WriteLine(x + "+");

                    }
                    else
                    {
                        Console.WriteLine(a +"-" );
                    }
                    a = a + 1;
                }
            
        }
    }
}
