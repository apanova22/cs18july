using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1 = double.Parse(Console.ReadLine());
            double B1 = double.Parse(Console.ReadLine());
            double A2 = double.Parse(Console.ReadLine());
            double B2 = double.Parse(Console.ReadLine());
            if (A1 < B1 && A2 < B2)
            {
                if (A1 < A2)
                {
                    if (B1 < A2)
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                    if (B1 > A2 && B1 < B2)
                    {
                        Console.WriteLine("Пересекаются({0};{1})", A2, B1);
                    }
                    if (B1 > B2)
                    {
                        Console.WriteLine("Пересекаются({0};{1})" , A2, B2 );
                    }
                    return;
                }

                if (A1 > A2)
                {
                    if (B2 < A1)
                    {
                        Console.WriteLine("Не пересекаются");
                    }
                    if (B2 > A1 && B2 > B1)
                    {
                        Console.WriteLine("Пересекаются({0};{1})" , A1,B1);
                    }
                    if (B2 > A1 && B2 < B1)
                    {
                        Console.WriteLine("Пересекаются({0};{1})" , A1,B2);
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
