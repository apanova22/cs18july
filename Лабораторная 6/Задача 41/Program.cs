using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            int i = 1;
            int a = Q - P + 1;
            int b = P - Q + 1; ;
            if (P >= Q)
            {
                while (P >= Q)
                {
                    if (i < a / 2)
                    {
                        Console.Write(Q+"<");
                        i++;
                    }
                    else
                    {
                        Console.Write(Q + ">");
                        i++;
                    }
                   
                    Q = Q + 1;
                    

                }
 
                

            }
            else
            {
                while (P <= Q)
                {
                    if (i <= a / 2)
                    {
                        Console.Write(P + "<");
                        i++;
                    }
                    else
                    {
                        Console.Write(P + ">");
                        i++;
                    }
                    
                    P = P + 1;
                    
                }
               
            }

        }
    }
}

