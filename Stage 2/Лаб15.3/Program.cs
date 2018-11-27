using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Лаб15._3
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
                String a = streamReader.ReadLine();
             
                String[] arr = a.Split(' ');
                HashSet<String> set = new HashSet<string>();
                
                int i = 0;
                 while (!streamReader.EndOfStream)
                    {
                    
                    while (i < arr.Length)
                    {
                        set.Add(arr[i]);
                        i++;

                    }
                  
                    String mes = String.Join(",", set);
                    Console.WriteLine(set.Count);
                    Console.WriteLine(mes);
                    streamReader.ReadLine();
                }

                
              
            }
          
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не существует");
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
