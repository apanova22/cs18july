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
       
            public static String task5662(double a, double b, double c)
        {
            if (a == 0)
            {
               Console.WriteLine("Данное уравнение не является квадратным");
               return "Данное уравнение не является квадратным";
            }

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);
                string x = string.Format("Вещественных корней уравнения {0}x^2 + {1}x + {2} = 0 нет", a, b, c);
                return x;
            }
            else if (d == 0)
            {
                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 один корень", a, b, c);
                string v = string.Format("У уравнения {0}x^2 + {1}x + {2} = 0 один корень", a, b, c);
                return v;
            }
            else
            {

                Console.WriteLine("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
                string n = string.Format("У уравнения {0}x^2 + {1}x + {2} = 0 два вещественных корня", a, b, c);
                return n;
            }
        


        }
     
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
        public static bool task4847 (int x, int y, int z)
        {
            bool result = x == y || y == z || x == z;
            return result;
            
        }
        public static double task9020(int x)
        {
            if (x > 61)
            {
                ArgumentException e = new ArgumentException("Подкоренное выражение должно быть неотрицательным");
                throw e;
            }
            double result = 3 * Math.Sqrt(61 - x);
            return result;
        }
        public static double task3943(int x, int y)
        {
          
            
            if (y < 0)
            {
                ArgumentException e = new ArgumentException("Значение y должно быть неотрицательным");
                throw e;
                
            }
            if ((x + Math.Sqrt(y)) < 0)
            {
                ArgumentException r = new ArgumentException("Подкоренное выражение должно быть неотрицательным");
                throw r;
            }
            double result;
            result = -5 * Math.Sqrt(x + Math.Sqrt(y));
            
            
            return result;
        }
        public static double task7799(int mass, int aDeg)
        {
            double g = 9.8067;
             if (mass <= 0)
            {
                ArgumentException e = new ArgumentException("Масса должна быть положительной");
                throw e;

            }
            if (aDeg > 90)
            {
                ArgumentException r = new ArgumentException("0");
                throw r;

            }

            double aRad = aDeg * Math.PI / 180;
            double force;
            force = mass * g * Math.Cos(aRad);
            return force;
        }
        public static double task9354(int a, int b, int c)
        
        {
            if (a == 0)
            {
                ArgumentException e = new ArgumentException("Уравнение y="+a+"x^2+"+b+"x+"+c+" не является квадратным");
                throw e;
            }
            double discriminant;
            discriminant = b * b - 4 * a * c;
            return discriminant;
        }
        public static string task5170 (int y)

        {   int a = 1;
            int count = 0;
            if (y < 0)
            {
                ArgumentException e = new ArgumentException("Значение Y должно быть положительным");
                throw e;
               
            }
            while (a <= y)
            {
                if (y % a == 0)
                {
                    count = count + 1;
                    a = a + 1;
                }
                else
                {

                    a = a + 1;
                }

            }
            if (count == 2)
            {
                
                return "число простое";
            }
            else
            {
                
                return "число не простое";
            }
        }
    }
}
