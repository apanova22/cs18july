using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task5081
{
    public class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "task5081/test" + n + ".txt";




            try
            {
                StreamReader streamReader = new StreamReader(filename);
                String line;
                line = streamReader.ReadLine();
                int[] p = Program.task5081(line);
                int i = 0;
                while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        p = Program.task5081(line);
                        int s=0;
                        while(i< p.Length)
                        {
                            s =s+p[i];
                            i++;
                        }
                       

                    }
                  Console.WriteLine(s);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Строка пуста");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл отсутствует");
            }

            public static int[] task5081(String line)
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
}
