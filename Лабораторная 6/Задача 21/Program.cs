using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
             long i = 0;

            if (A < B)
            {
                while (A <= B)
                {

                    i = i + A * A;


                    A = A + 1;
                }
                Console.WriteLine( i);
            }
            else
            {

                while (B <= A)
                {
                    i = i +A*A;
                    A = A - 1;
                }
                Console.WriteLine(i);
            }
        }
    }
}
