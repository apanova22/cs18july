using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefwxyz";
            String x = Console.ReadLine();
            //Вызов метода Contains у переменной str
            bool isXinStr = str.Contains(x);
            if (isXinStr == true)
            {
                Console.WriteLine("Cодержится");

            }
            else
            {
                Console.WriteLine("Не содержится");
            }
        }
    }
}
