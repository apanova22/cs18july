using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
                String[] arr = data.Split(' ');
                while (a<arr.Length)
                {
                    Console.WriteLine(arr[b] + " " + a);
                    
                    a = a + 1;
                    b = b + 1;
                    
                }
               

            }
        }
    }
}
