using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            if (B<0 || B>arr.Length)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива) ");
                return;
            }
            int i = 0;
            int count = 0;
            Console.Write(" ");
            while (i < arr.Length)
            {
                if (num[B]>num[i])
                {
                    count = count + 1;
                    
                }
                
                
                else
                {

                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}
