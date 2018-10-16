using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task5081
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "task5081/test" + n + ".txt";

            StreamReader streamReader = new StreamReader(filename);
            String s = streamReader.ReadLine();

            try
            {
                int sum = int.Parse(s);
                if (!streamReader.EndOfStream)
                { String line;
                    int l;
                    int i = 0;
                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        l = int.Parse(line);
                        char[] ch = line.ToCharArray();
                        while (i < ch.Length)
                        {
                            sum = sum + ch[i];
                        }

                    }

                }
                Console.WriteLine(sum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
        }
    }
}
