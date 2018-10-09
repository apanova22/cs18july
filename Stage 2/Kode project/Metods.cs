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
        public static void task2632(int cx, int cy, int r, String fill)
        {
            Console.WriteLine(@"< circle cx = ""{0}"" cy = ""{1}""" + "\n" + @"r=""{2}"" fill=""{3}""/>", cx, cy, r, fill);
        }
        public static void task7474(int a, int b, int c)
        {
            Console.WriteLine("Квадратное уравнение: {0} * x * x + {1} * x + {2} = 0.", a,b,c);
            Console.WriteLine("Его дискриминант вычисляется по формуле: d = {0} *{0} - 4 *{1}*{2}",b,a,c); 

        }
        /*
            public static String task5662(double a, double b, double c)
        {
            if (a == 0)
            {
               Console.WriteLine("Данное уравнение не является квадратным");
              
            }

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);

            }
            else if (d == 0)
            {
                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 один корень", a, b, c);
            }
            else
            {

                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
            }
            return; 
           
        }
        */
        public static long task3669(int a, int b)
        {
            long p = 1;
            if (a < b)
            {
                while (a <= b)
                {
                    p = p * a;

                    a = a + 1;
 }
            }
            else
            {
                while (b <= a)
                {
                    p = p * b;

                    b = b + 1;
                }
            }
            return p;
        }

    }
}
