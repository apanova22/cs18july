﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
            }
            while (B>=A)
            {
                Console.Write(B+" ");
                B = B - 1;
            }
        }
    }
}
