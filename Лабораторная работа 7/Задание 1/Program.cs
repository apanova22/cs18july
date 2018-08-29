using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            String data;
            a = int.Parse(Console.ReadLine());
            data= Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("исходная строка пуста");
                return;
            }
            String[] arr = data.Split(' ');
            if (a<0 || a>=arr.Length)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
                return;
            }
            Console.WriteLine(arr[a]);

        }
    }
}
