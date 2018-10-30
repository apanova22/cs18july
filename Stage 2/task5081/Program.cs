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
            String filename = "task5081/test" + n + ".txt";
            try {
                StreamReader streamReader = new StreamReader(filename);
                while (!streamReader.EndOfStream)
                {
                    try
                    {

                        String[] arr;
                        int[] num;
                        String line;
                        int a;
                        int sum = 0;
                        while (!streamReader.EndOfStream)
                        {
                            line = streamReader.ReadLine();

                            arr = line.Split(',');
                            num = new int[arr.Length];

                            a = 0;
                            while (a < num.Length)
                            {
                                num[a] = int.Parse(arr[a]);
                                a++;
                            }
                            a = 0;
                            sum = 0;
                            while (a < num.Length)
                            {
                                sum = sum + num[a];
                                a++;
                            }

                            Console.WriteLine(sum);
                        }



                    }
                   
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Некорректный формат данных");
                    }
 catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
                }
            }
 catch (FileNotFoundException e)
                    {
                        Console.WriteLine("Файл не существует");
                    }
           
            
            }





        }
       
        
    }

