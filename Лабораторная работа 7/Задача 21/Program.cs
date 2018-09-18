using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] top = data.Split(' ');
            String data1 = Console.ReadLine();
            String[] left = data1.Split(' ');
            int i = 0;
            int o = 0;
            int count = 0;
            while (o<left.Length)
            {
                while (i < top.Length)
                {
                    if (top[i].Equals(left[o]))
                    {
                        count++;


                    }
                    else
                    {


                    }

                    i++;
                }
                i = 0;
                o++;
            }
            Console.WriteLine("Повторений:{0}",count);
        }
    }
}
