using System;
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
            Random rnd = new Random();
            int[] mas = new int[10];
            int i = 0;
            int a;
            while ( i < 10)
            {
                a = rnd.Next(0, 10);
                Console.WriteLine(a);
                i++;
            }
            
           
        }

    } }

