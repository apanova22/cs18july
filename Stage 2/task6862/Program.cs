using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task6862
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "task6882/test"+n+".txt";

            
           

            try
            {
StreamReader streamReader = new StreamReader(filename);
 String min = streamReader.ReadLine();
                int m = int.Parse(min);
                if (!streamReader.EndOfStream)
                {


                    String line;
                    int l;

                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        l = int.Parse(line);
                        if (l < m)
                        {
                            m = l;
                        }

                    }

                }
                Console.WriteLine(m);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Файл пуст");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не существует");
            }
            
        }
    }
}
