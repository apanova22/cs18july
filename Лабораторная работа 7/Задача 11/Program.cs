using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            int a = 0;
            data = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            while (a<arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            while (a<arr.Length)
            {
                num[a] = num[a] * m;
                
                Console.WriteLine(num[a]);
a++;
            }
        }
    }
}
