using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {   String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            String data1 = Console.ReadLine();
            String[] art = data1.Split(' ');
            int u = 0;
            int i = 0;
            int r = 0;
           
            int m = art.Length;
            int[] num = new int[m];
            if (art.Length!=arr.Length)
            {
                Console.WriteLine("Длины массивов не совпадают");
                return;
            }
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Отсутствуют данные о символах");
                return;
            }
            if (String.IsNullOrWhiteSpace(data1))
            {
                Console.WriteLine("Отсутствуют данные о количествах");
                return;
            }
            while (i < art.Length)
            {
                num[i] = int.Parse(art[i]);
                i++;
            }      
            i = 0;
            int p = 0;
            while (r<arr.Length)
            {
                while (u < num[p])
                {
                    Console.Write(arr[i]);
                    
                    u++;
                }
                Console.WriteLine();
                p++;
                 
                
                u = 0;
                i++;
            }
            
        }

    }
}
