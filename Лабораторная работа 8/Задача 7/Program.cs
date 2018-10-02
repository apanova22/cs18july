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
            String str = Console.ReadLine(); 
            
            if (str.Length!=13)
            {
                Console.WriteLine("Некорректная длина штрих-кода");
                return;
            }
        
            String part = str.Substring(0, 2);
            String part1 = str.Substring(3,3);
            String part2 = str.Substring(7,4);
            String part3 = str.Substring(12,1);
            Console.WriteLine("Код страны:{0}" , part);
            Console.WriteLine("Код изготовителя:{0}", part1);
            Console.WriteLine("Код товара:{0}", part2);
            Console.WriteLine("Контрольное число:{0}", part3);


        }
    }
}
