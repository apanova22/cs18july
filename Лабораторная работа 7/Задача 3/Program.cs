using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            int a = 0;
            
            data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine();
                return;
            }
            String[] arr = data.Split(' ');
            int b = arr.Length-1;
            while (a <= b)
            {
                Console.Write(arr[b]+" ");

                b=b-1;
              

            }
        }
    }
}
