using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String[] arr = a.Split(' ');
            Dictionary<String, int> pairs = new Dictionary<string, int>();
          

            int i = 0;
            while (i<arr.Length)
            {
                if (pairs.ContainsKey(arr[i]))
                {
                    pairs[arr[i]]++;
                }
                else
                {
                    pairs.Add(arr[i], 1);

                }
                i++;
            }
            foreach (var key in pairs.Keys)
            {
                Console.WriteLine(key+" "+pairs[key]);
            }
        }
    }
}
