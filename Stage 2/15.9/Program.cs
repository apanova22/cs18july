using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kode_project;

namespace _15._9
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Comparator8258 comparator8258 = new Comparator8258();
           
           
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(7);
            list.Add(10);
            
            comparator8258.l = 10;
list.Sort(comparator8258);
 int result = comparator8258.Compare(1, 10);
 Console.WriteLine(result);
            Console.WriteLine(String.Join(",",list));

          
        }
    }
}
