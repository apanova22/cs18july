using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int n = arr.Length;
            int[] numbers = new int[n];
            int i = 0;
            while (i < numbers.Length)
            {
                numbers[i] =int.Parse(arr[i]);
                i++;
            }
            i = 0;
            while (i < numbers.Length)
            {
               numbers[i]=(numbers[i]*m);
                i++;
            }
            i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i]+ " ");
                i++;
            }

        }
    }
}
