using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String data;
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            
            int b = 0;
            data = Console.ReadLine();
           
            String[] arr = data.Split(' ');
            if (p < 0 || p >= arr.Length)
            {
                Console.WriteLine("Число P должно быть в интервале [0, размер массива)");
                return;
            }
            if (q < 0 || q >= arr.Length)
            {
                Console.WriteLine("Число Q должно быть в интервале [0, размер массива)");
                return;
            }
            
            String t;
            t = arr[p];
            arr[p] = arr[q];
            arr[q] = t;
            while (b < arr.Length)
            {
                Console.Write(arr[b] + " ");

               
                b = b + 1;

            }
           

        }
    }
}
