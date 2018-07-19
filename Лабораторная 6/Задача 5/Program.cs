using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            String B = Console.ReadLine();
            if(A<0)
            { 
                Console.WriteLine("Значение A должно быть неотрицательным");
            return;
            }
        Console.Write("\"");
             int i=0;
            while (i < A)
            {
                Console.Write(B);
                i=i+1;
            }
            Console.WriteLine("\"");

        }
    }
}
