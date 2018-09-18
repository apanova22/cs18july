using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
data = Console.ReadLine();

            String[] arr = data.Split(',');

            int a = 0;
            int b = arr.Length - 1; 
            
            while (a<=b)
            {
                Console.Write(arr[b]+" ");
                b--;
            }
            
        }
    }
}
