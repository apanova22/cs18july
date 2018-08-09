using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            a = int.Parse(Console.ReadLine());
            int count = 1;
            int sum = a;
            while (sum<=1000)
            {

                count = count + 1;
                a = int.Parse(Console.ReadLine());



                sum = sum + a;
            }
            Console.WriteLine( count);
           
        }
    }
}
