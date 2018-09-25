using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];
            int a = 0;
            int u = P+1;
             while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            a = 0;
            if (Q<0 || Q>=arr.Length)
            {
                Console.WriteLine("Число Q должно быть в интервале[0, размер массива)");
                return;
            }
            if (P < 0 || P >= arr.Length)
            {
                Console.WriteLine("Число P должно быть в интервале[0, размер массива)");
                return;
            }


            while (u <= Q)
            {
                if (num[P] > num[u])
                {
                    P = u;

                }
                else
                {
                    
                }
                
                u++;

            }
            Console.WriteLine(num[P]);



            
              
        }
    }
}
