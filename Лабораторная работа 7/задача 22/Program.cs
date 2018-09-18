using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] top = data.Split(' ');
          
            int i = 0;
            int a=1;
            int y = 0;
            int count = 0;
            while (y <top.Length)
            {
                while (a < top.Length)
                {
                    if (top[y].Equals(top[a]))
                    {
                        count++;
                      }
                    else
                    {  }

                    a++;
                }
                a = 1;
                y++;
            }

            if (count > 0)
            {
                Console.WriteLine("Повторения есть");
            }
            else
            {
                Console.WriteLine("Повторений нет");
            }
        }
    }
    }

