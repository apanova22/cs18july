using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthSeconds = int.Parse(Console.ReadLine());

          
            int hour = lengthSeconds/3600;
            int minute = lengthSeconds - (hour * 3600);
            int second = lengthSeconds - (hour * 3600)-(minute*60);
            Console.WriteLine("{0}часов{1}минут{2}секунд",hour,minute,second);
        }
    }
}
