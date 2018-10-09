using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metods.task1860("знаниям");
            // Metods.task1860("целям");
            // Metods.task1860("результату");

            //Metods.task4140("Джеймс","  Бонд.");
            //Metods.task4140("капитан"," Джек Воробей.");
            //Metods.task4140("Александр", "Крюков.");

            /* Metods.task2632(50, 50, 40, "yellow");
            Metods.task2632(400, 300, 200, "green");
            Metods.task2632(254, 356, 100, "#cc6600"); */

            // Metods.task7474(1, 2, 3);
            //Metods.task7474(-3, 0, 2);

            double r1 = Metods.task9020(0);
            Console.WriteLine("{0:F4}",r1);
            double r2 = Metods.task9020(-9);
            Console.WriteLine("{0:F4}", r2);
            double r3 = Metods.task9020(61);
            Console.WriteLine("{0:F4}", r3);
            double r4 = Metods.task9020(60);
            Console.WriteLine("{0:F4}", r4);
            try
            {
                double r5 = Metods.task9020(62);
               
               
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
              
            }
            try
            {
                double r6 = Metods.task9020(7573);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                double r7 = Metods.task9020(75);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

    }

}
