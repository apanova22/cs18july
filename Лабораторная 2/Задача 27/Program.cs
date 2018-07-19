using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8067;
            double mass = double.Parse(Console.ReadLine());
            double velocity = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            if (mass <= 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            if (velocity <= 0)
            {
                Console.WriteLine("Значение velocity должно быть положительным");
                return;
            }
            if (height < 0)
            {
                Console.WriteLine("Значение height должно быть неотрицательным");
                return;
            }
            double kineticEnergy;
            kineticEnergy = mass*velocity*velocity/2;
            double potentialEnergy;
            potentialEnergy = mass * g * height;
            Console.WriteLine("Кинетическая энергия составляет: {0} Дж\n"+
"Потенциальная энергия составляет: {1} Дж", kineticEnergy, potentialEnergy);
        }
    }
}
