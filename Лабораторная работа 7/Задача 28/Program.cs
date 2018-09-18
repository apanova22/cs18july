using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            int i = 0;
            int u = 1;
            int x = 0;
            int t;
            
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }

            a = 0;

            while (x < arr.Length)
            {
                while (u < arr.Length)
                {
                    if (num[a] > num[u])
                    {
                        a =u;

                    }
                    else
                    {
                    }

                    u++;
                   
                }
                
                
                t = num[a];
                num[a] = num[x];
                num[x] = t;
x++;
a = x;
                u = x + 1;
                
                Console.WriteLine(String.Join(" ", num));
            }
           

        }
    }
    }

