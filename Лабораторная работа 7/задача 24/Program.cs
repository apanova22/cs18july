using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_24
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
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            Console.WriteLine("Ход решения:");
            Console.WriteLine("Начинаю с {0}",num[a]);
            while (u<arr.Length)
            {
                if (num[a] > num[u])
                {
                    Console.WriteLine("Сравниваю {0} и {1} ",num[a],num[u]);
                    Console.WriteLine("Заменяю");
                    a = u;

                }
                else
                {
                    Console.WriteLine("Сравниваю {0} и {1} ", num[a], num[u]);
                }
                u++;
                
            }
            Console.WriteLine("В массиве {0} минимальный элемент это {1} ",String.Join(" ",arr),num[a]);
      
        }
    }
}
