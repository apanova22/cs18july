using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                String x = Console.ReadLine();
                String data = "a b c d e f g h";
                String[] arr= data.Split(' ');
                int i;
                i = 0;
                while (i < arr.Length)
                {
                    if (x == arr[i])
                    {
                        Console.WriteLine(arr[i] + "+");
                        i++;

                    }
                    else
                    {
                        Console.WriteLine(arr[i]);
                        i++;
                    }
                }
               

            }
        }
    }
}
