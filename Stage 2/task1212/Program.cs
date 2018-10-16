using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task1212
{
    public class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "task1212/test" + n + ".csv";


            try
            {
                StreamReader streamReader = new StreamReader(filename);
                String line;
                line = streamReader.ReadLine();
                int[] p = Program.task1212(line);
                int m = p[2] * p[3];

                while (!streamReader.EndOfStream)
                {



                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        p = Program.task1212(line);
                        int s = p[2] * p[3];

                        if (s > m)
                        {
                            m = s;
                        }
                    }


                }
                Console.WriteLine(m);
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
        public static int[] task1212(String line)
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

    }
}
