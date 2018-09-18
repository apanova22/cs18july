using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            int a = 0;
            int i = 0;
            double sum = 0;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            while (i < arr.Length)
            {

                sum = sum + num[i];

                i++;

            }
            i = 0;
            double sr=sum / arr.Length;
           
            while (i<arr.Length)
            {

                Console.Write(Math.Abs(sr-num[a])+" ");
                i++;
                a++;
            }
          
        }
    }
}
