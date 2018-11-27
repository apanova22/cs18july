using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String[] arr =a.Split(' ');
            List<String> list = new List<string>();
            Console.WriteLine(list.Count);
            int i= 0;
            while (i < arr.Length)
            {
                list.Add(arr[i]);
                i++;
            }
            Console.WriteLine(list.Count);
            Console.WriteLine(list[0]);
            String message = String.Join(",", list);
            Console.WriteLine(message);

            HashSet<String> set = new HashSet<string>();
            set.Add(arr[0]);
            i = 0;
            while (i<arr.Length)
            {
                set.Add(arr[i]);
                i++;

            }
            Console.WriteLine(set.Count);
            String mes = String.Join(",", set);
            Console.WriteLine(mes);




        }
    }
}
