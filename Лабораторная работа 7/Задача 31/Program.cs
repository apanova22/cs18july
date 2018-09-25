using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {

            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int[] nem = new int[arr.Length];
            int a = 0;
            int u = 0;
            int c = a;
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            while (a < arr.Length)
            {
                while (u < arr.Length)
                {
                    if (num[a] == num[u])
                    {
                        nem[c]++;
                    }
                    else
                    {
                    }
                   
                    u++;
                   
                }
                a++;
                u = 0;
                c = a;
            }

            Console.WriteLine(String.Join(" ", nem));



        }
    }
}