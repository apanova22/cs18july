using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            String s = ".";
            int i = 0;
            int n = 1;
            
            if (A >= B)
            {
                while (A>=B)
                {
                    if (B%2!=0)
                    {
                         Console.WriteLine(B);
                        if (A != B)
                        {
                            while (i < n)
                            {
                                Console.Write(s);
                                i = i + 1;

                            }
                        }
                        else
                        {
                            return;
                        }
                            

                            i = 0;
                            n = n + 1;
                        
                       
                    }
                    else
                    {

                    }
                    B = B + 1;
                }
                
            }
            else
            {
                while (A <= B)
                {
                    if (A % 2 != 0)
                    {
                        Console.WriteLine(A);
                        if (A!=B)
                        {

                            while (i < n)
                            {
                                Console.Write(s);
                                i = i + 1;
                              

                            }
                        }
                        else
                        {
                            return;
                        }
                       
                        i = 0;
                        n = n + 1;
                        
                        
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
