using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task1212
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "task1212/test" + n + ".csv";
            StreamReader streamReader = new StreamReader(filename);
            String max = streamReader.ReadLine();

            try
            {
                int m = int.Parse(max);
                if (!streamReader.EndOfStream)
                {
                    String line;
                    line = streamReader.ReadLine();
                    char[] ch = line.ToCharArray();
                    int s = ch[2] * ch[3];
                     if (s > m)
                        {
                            m = s;
                        }

                    

                }
                Console.WriteLine(m);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }




        }
    }
}
