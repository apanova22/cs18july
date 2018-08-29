using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A >= B)
            {
                while (A >= B)
                {
                    if (A % 2 != 0)
                    {
                        if (A==B ||A==B-1 || A == B + 1)
                        {
                            Console.Write(A + " ");
                        }
                        else
                        {
                            Console.Write(A + ", ");
                        }
                        
                    }
                    else
                    {

                    }
                    A = A - 1;
                }

            }
            else
            {
                while (A <= B)
                {
                    if (A % 2 != 0)
                    {
                        if (A == B || A == B -1 || A == B + 1)
                        {
                            Console.Write(A+" ");
                        }
                        else
                        {
                            Console.Write(A + ", ");
                        }
                    }
                    else
                    {

                    }
                    A = A + 1;
                }
            }
        }
    }
}

