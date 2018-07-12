using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            if (p > q)
            {
                Console.WriteLine("Максимальное{0},минимальное{1}",p,q);
            }
            
            else
            {
                Console.WriteLine("Максимальное{0},минимальное{1}",q,p);
            }
        }
    }
}
