using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "test" + n + ".txt";
            try
            {
               
               
                StreamReader streamReader = new StreamReader(filename);

                Dictionary<String, int> pairs = new Dictionary<string, int>();
                
                while (!streamReader.EndOfStream)
                {
 String a = streamReader.ReadLine();
                
                    if (pairs.ContainsKey(a))
                    {
                        pairs[a]++;
                    }
                    else
                    {
                        pairs.Add(a, 1);

                    }
                    
                }
                



                String p=" ";
                int l = 0;

                foreach (var key in pairs.Keys)
                {
                
                    if (l<pairs[key])
                    {
                        l = pairs[key];
                        p = key;
                    }
                    else
                    {
                    }
                    

                }
                Console.WriteLine(p);

            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не существует");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
