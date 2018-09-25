using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            int count = 0;
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            while (a < arr.Length)
            {
                if (num[a] == K)
                {
                    count++;
                }
                else
                {
                }
                a++;
            }
            Console.WriteLine(count);
        }
    }
}
