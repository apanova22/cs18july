using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
    public class Metods
    {
        public static void task1860(String x)
        {
            Console.WriteLine("Мы стремимся к "+x);
        }
        public static void task4140(String x, String y)
        {
            Console.WriteLine("Меня зовут {0}, {1} {0}.",y,x);
        }
        public static double task4411(double x)
        {
            double result;
            result = x + 7;
            return result;
        }
        public static double task2790(double x)
        {
            double xRad = x * Math.PI / 180;
            //double r = Math.Pow(1 - Math.Pow(Math.Sin(xRad),2), 0.5);
            double r = Math.Pow( Math.Pow(Math.Cos(xRad), 2), 0.5);
            return r;
        }
        public static double task3946(int[] arr)
        {
            double sum = 0;
            int i = 0;
            while (i<arr.Length)
            {
                sum += arr[i];
                i++;
            }
            double result = sum / arr.Length;
            return result;
        }
        public static int task4283(int k,int[] arr)
        {
            int c = 0;
            int i = 0;
            
            while (i<arr.Length)
  {
                if (k == arr[i])
                {
                    c++;
                }
                i++; 
            }
            return c;
        }

        public static void task9774(double m, double[] arr)

        {
            int i = 0;
            while (i < arr.Length)
            {
                arr[i] = arr[i] * m;
                i++;
            }
        }

    }
}
