using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0;
            String data = Console.ReadLine();
            
            String[] arr = data.Split(' ');
            String data1 = Console.ReadLine();

            String[] ark = data1.Split(' ');
            int[] num = new int[arr.Length];
            int[] num1 = new int[ark.Length];
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            while (a < ark.Length)
            {
                num1[a] = int.Parse(ark[a]);
                a++;
            }
            a = 0;
            
            int  b = arr.Length;
            int[] sum = new int[b];
            while (a < b)
            {
                
                  sum[a] = num[a] * num1[a];
                Console.WriteLine("{0}={1}*{2}",sum[a],num[a],num1[a]);
                
                a++;
            }
        }
    }
}
