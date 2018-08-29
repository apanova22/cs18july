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
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if(A>B){
            while (B<=A)
            {
                Console.Write(B);
                B = B + 1;
            }
            }
            else{
                while(A<=B)
                {
                    Console.Write(A);
                    A=A+1;
                }
            }

        }
        }
    }

