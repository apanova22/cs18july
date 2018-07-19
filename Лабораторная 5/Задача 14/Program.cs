using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftA = int.Parse(Console.ReadLine());
            int leftB = int.Parse(Console.ReadLine());
            int rightA = int.Parse(Console.ReadLine());
            int rightB = int.Parse(Console.ReadLine());
            if (leftA < leftB && rightA < rightB)
            {
                if (leftA < rightA)
                {
                    if (leftB < rightA)
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                    if (leftB > rightA && leftB < rightB)
                    {
                        Console.WriteLine("Пересекаются");
                    }
                    if (leftB > rightB)
                    {
                        Console.WriteLine("Пересекаются");
                    }
                    return;
                }

                if (leftA > rightA)
                {
                    if (rightB < leftA)
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                    if (rightB > leftA && rightB>leftB)
                    {
                        Console.WriteLine("Пересекаются");
                    }
                    if (rightB > leftA && rightB < leftB)
                    {
                        Console.WriteLine("Пересекаются");
                    }
                            
                }
            }
            else
            {
                Console.WriteLine("Значение А должно быть меньше В");
            }
        }
    }
}
