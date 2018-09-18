using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            int a = 0;
            int b = 0;
            data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("исходная строка пуста");
                return;
            }
            String[] arr = data.Split(';');
            int c = arr.Length - 1; 
            while (a <= c)
            {
               

                a = a + 1;
                b = b + 1;

            }
            b = b / 2;
            Console.WriteLine(b);
            Console.WriteLine(arr[b]);
        }
    }
}
