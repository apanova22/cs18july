﻿using System;
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
            Metods.task2632(254, 356, 100, "#cc6600"); 

             Metods.task7474(1, 2, 3);
            Metods.task7474(-3, 0, 2);

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

            double r1 = Metods.task3943(-5,81);
            Console.WriteLine("{0:F4}", r1);
            double r2 = Metods.task3943(7507,7499);
            Console.WriteLine("{0:F4}", r2);
            try
            {
                double r3 = Metods.task3943(7489,-7487);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                double r4 = Metods.task3943(-7481, 7477);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            } 



           
            double p = Metods.task7799(5, 45);
            Console.WriteLine("{0:F4}",p);
            double l = Metods.task7799(7297, 30);
            Console.WriteLine("{0:F4}", l);
            double l1 = Metods.task7799(10, 90);
            Console.WriteLine("{0:F4}", l1);
            
            
            try
            {
                double r1 = Metods.task7799(7, 91);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                double r2 = Metods.task7799(9, 100);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                double r3 = Metods.task7799(0, 30);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
             } 

          double p = Metods.task9354(7, 1,3);
          Console.WriteLine("{0:F6}", p);
            double p1 = Metods.task9354(7247, 7243, 7229);
            Console.WriteLine("{0:F6}", p1);
            double p2 = Metods.task9354(-11,-13,-17);
            Console.WriteLine("{0:F6}", p2);
            try
            {
                double r1 = Metods.task9354(0,1,3);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                double r2 = Metods.task9354(0,1000,2000);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            } 
           string p1 = Metods.task5170(6);
            Console.WriteLine(p1);
            string p2 = Metods.task5170(3219);
            Console.WriteLine(p2);
            string p3 = Metods.task5170(7);
            Console.WriteLine(p3);
            string p4 = Metods.task5170(2017);
            Console.WriteLine(p4);
            try
            {
                string r1 = Metods.task5170(-10);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            } 

           bool r1= Range.HasIntersection(2,3,5,7);
            Console.WriteLine(r1);
            bool r2= Range.HasIntersection(11, 17, 13, 19);
            Console.WriteLine(r2);
            bool r3=Range.HasIntersection(23, 37, 29, 31);
            Console.WriteLine(r3);
            bool r4= Range.HasIntersection(43, 53, 41, 47);
            Console.WriteLine(r4);
            bool r5= Range.HasIntersection(5, 15, 0, 30);
            Console.WriteLine(r5);
            bool r6=Range.HasIntersection(67, 71, 59, 61);
            Console.WriteLine(r6);
           try
            {
                
Range.HasIntersection(79, 73, 83, 89);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                

 Range.HasIntersection(97, 101, 107, 103);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }*/

           Point a= new Point(31,37);
           Console.WriteLine(a);
           Point p1= new Point(11,13);
           Point p2= new Point(17,19);
           double u=Point.distanceBetween(p1, p2);
            Console.WriteLine("Расстояние между {0} и {1} составляет {2:F4}\n",p1,p2,u);

        }
  
    }
   
      

    
}
