using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task9472
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "task9472/test" + n + ".csv";


            try
            {
                StreamReader streamReader = new StreamReader(filename);
                String line;
                line = streamReader.ReadLine();
                
                int [] c = Program.circle(line);
                int[] r = Program.rect(line);
                int m = r[3] * r[4];
                double k = Math.PI * c[3]*c[3];
                while (!streamReader.EndOfStream)
                {
                     while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        if (c[0] == "circle")
                        {
                            c = Program.circle(line);
                            double o = Math.PI * c[3] * c[3];

                            if (o > k)
                            {
                                k = o;
                            }
                        }
                        else
                        {
                            r = Program.rect(line);
                            int s= r[3] * r[4];
                            if (s > m)
                            {
                                m = s;
                            }
                        }
                    }


                }
                if (c[0] == "circle")
                {
                    Console.WriteLine(k);
                }
                else
                {
                    Console.WriteLine(m);
                }


            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не существует");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Некорректный формат данных");
            }





        }
        public static int[] rect(String line)
        {

            String[] arr = line.Split(';');
            int[] num = new int[arr.Length];

            int a = 0;
            while (a < arr.Length)
            {
                num[a] = int.Parse(arr[a]);
                a++;
            }
            return num;
        }
        public static int[] circle(String line)
        {

            String[] arr = line.Split(';');
            int[] nam = new int[arr.Length];

            int a = 0;
            while (a < arr.Length)
            {
                nam[a] = int.Parse(arr[a]);
                a++;
            }
            return nam;
        }
    }
    }

