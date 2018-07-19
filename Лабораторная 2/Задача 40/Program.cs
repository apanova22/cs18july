using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_40
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume1 = double.Parse(Console.ReadLine());
            double temperature1 = double.Parse(Console.ReadLine());
            double volume2 = double.Parse(Console.ReadLine());
            double temperature2= double.Parse(Console.ReadLine());
            if (volume1 < 0 || volume2 < 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            double temperature;
            double volume;
            volume = volume1 + volume2;
            temperature = (temperature1 * volume1 + temperature2 * volume2)/( volume1 + volume2);
            Console.WriteLine("{0} {1:F4}", volume, temperature);
        }
    }
}
