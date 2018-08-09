using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int i = B;
            if (A > B)
            {
                while (B <= A)
                {
                    Console.WriteLine(i+" "+A);
                    A = A - 1;
                    i = i + 1;

                }
              
            }
            else
            {
                while (A <= B)
                {
                    Console.WriteLine(A + " " +i);
                    A = A + 1;
                    i = i - 1;
                }
            }
        }
    }
}
