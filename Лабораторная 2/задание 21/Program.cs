using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalM = int.Parse(Console.ReadLine());
            int partCm = int.Parse(Console.ReadLine());
            int result;
            int res;
            if (totalM <= 0)
            {
                Console.WriteLine("Длина рулона должна быть положительна");
                return;
            }
            if (totalM < partCm)
            {
                Console.WriteLine("Материала не хватит даже на одно изделие");
                return;
            }
            if (partCm <= 0)
            {
                Console.WriteLine("Расход материала должен быть положительным");
                return;
            }
            
            result =totalM*100/partCm ;
            res = totalM*100 % partCm;
            Console.WriteLine("{0} шт и {1}см",result,res);
           

        }
    }
}
