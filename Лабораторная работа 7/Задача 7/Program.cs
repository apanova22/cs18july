﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            int S = int.Parse(Console.ReadLine());
            int i = 0;
            int a = 0;
            int q = 0;
            data = Console.ReadLine();

            String[] arr = data.Split(' ');

            
            while (q < S)
            {
            int b = arr.Length - 1;
            String t;
            t = arr[b];
                while (i < b)
                {
                    arr[b] = arr[b - 1];
                    b--;

                }
                
                arr[b] = t;
                q++;
            }
            q = 0;
            while (q < S)
            {
                while (a < arr.Length)
                {
                    Console.Write(arr[a] + " ");


                    a = a + 1;

                }
            }

        }
    }
}
