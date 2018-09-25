using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            while (a < arr.Length)
            {
                if (num[a]==X)
                {
                    num[a] = Y;
                }
                else
                {
                }
                a++;
            }
            Console.WriteLine(String.Join(" ", num));
        }
    }
}
