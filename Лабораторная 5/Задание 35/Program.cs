using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if (t < 0 || t > 59)
            {
                Console.WriteLine("Значение t должно быть в интервале [0;59] ");
                return;
            }
            if (t % 5 >= 3)
            {
                Console.WriteLine("Красный");
            }
            else
            {
                Console.WriteLine("Зеленый");
            }
        }
    }
}
