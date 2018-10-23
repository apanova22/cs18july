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
                if (streamReader.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                    return;
                }
                String line;
                line = streamReader.ReadLine();
                
  Figura c = Program.circle(line);
 Figura r = Program.rect(line);
                double k;

                if (c.type == "circle")
                {

                    k = Math.PI * c.p[2] * c.p[2];
                }
                else if (r.type == "rect")
                {

                    k = r.p[2] * r.p[3];
                }
                else
                {
                    Console.WriteLine("Некорректный формат данных");
                    return;
                }
                
                while (!streamReader.EndOfStream)
                {
                     while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
c = Program.circle(line);
                        if (c.type == "circle")
                        {
                            
                            double o = Math.PI * c.p[2] * c.p[2];

                            if (o > k)
                            {
                                k = o;
                            }
                        }
                        else if (r.type == "rect")
                        {
                            r = Program.rect(line);
                            int s= r.p[2] * r.p[3];
                            if (s > k)
                            {
                                k = s;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный формат данных");
                            return;
                        }
                    }


                }
                
                    Console.WriteLine(k);
                


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
        public static Figura rect(String line)
        {

            String[] arr = line.Split(';');
            int[] num = new int[arr.Length-1];

            int a = 1;
            while (a <= num.Length)
            {
                num[a-1] = int.Parse(arr[a]);
                a++;
            }
            Figura r=new Figura();
            r.type = arr[0];
            
            r.p= num;
            return r;
        }
        public static Figura circle(String line)
        {

            String[] arr = line.Split(';');
            int[] nam = new int[arr.Length-1];

            int a = 1;
            while (a <= nam.Length)
            {
                nam[a-1] = int.Parse(arr[a]);
                a++;
            }
            Figura c = new Figura();
            c.type = arr[0];
            c.p = nam;
            return c;
        }
    }

    }

