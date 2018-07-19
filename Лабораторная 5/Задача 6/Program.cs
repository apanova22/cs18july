using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {

            double shipKmH = double.Parse(Console.ReadLine());
            double cometMS = double.Parse(Console.ReadLine());
            double shipMS = shipKmH*1000/3600;
            
            if (shipKmH < 0)
            {
                Console.WriteLine("Скорость корабля должна быть неотрицательна");
                return;
            }
            if (cometMS < 0)
            {
                Console.WriteLine("Скорость кометы должна быть неотрицательна");
                return;
            }
            if (cometMS < shipMS)
            {
                Console.WriteLine("Корабль догонит комету. Скорость кометы {0} м/с меньше скорости корабля {1} км/ч", cometMS, shipKmH);

            }
            else
            {
                Console.WriteLine("Комета улетит от корабля. Скорость корабля {0} меньше скорости кометы {1} м/с", shipKmH,cometMS);
            }
        }
    }
}
