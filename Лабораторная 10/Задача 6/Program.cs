using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(100, 999);
                Console.WriteLine(a[i]);
            }
        }
    }
}
