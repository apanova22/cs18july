using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            int b;
            int u = 1;
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            
           
            while (u < arr.Length)
            {
                if (num[a] > num[u])
                {
                    a = u;
                }
                else
                {
                }
                u++;

            }
            u= 0;
            b=num[a];
            a = 0;
            while (u<arr.Length)
            {
                num[a] = num[a] - b;
                    Console.Write(num[a]+" ");
                a++;
                    u++;
            }
        }
    }
}
