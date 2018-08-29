using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            
            int a = 0;
            if (A < B)
            {
                while (A <= B)
                {
                    if (A % 7 == 0)
                    {

                        a = a + A;


                    }
                    else
                    {
                        Console.Write("");

                    }
                    A = A + 1;



                }
            }
            else
            {
                while (A >= B)
                {
                    if (A % 7 == 0)
                    {

                        a = a + A;


                    }
                    else
                    {
                        Console.Write("");

                    }
                    A = A - 1;
                }
            }

            Console.WriteLine(a);
        }
    }
}
