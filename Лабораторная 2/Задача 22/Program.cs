using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInitial = double.Parse(Console.ReadLine());
          
           
            double aRemainder;
            aRemainder = aInitial%360;
            Console.WriteLine(aRemainder);
        }
    }
}
