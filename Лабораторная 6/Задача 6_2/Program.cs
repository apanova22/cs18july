using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            int start, end;

            if (A < B)
            {
                start = (int)A;
                end =(int) B;
            }
            else
            {
                start =(int) B;
                end =(int) A;
            }
            while (start <= end)
            {
                Console.WriteLine(start);
                start = start + 1;
            }
        }
    }
}
