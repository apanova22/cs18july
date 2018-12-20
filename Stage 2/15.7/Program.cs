using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Kode_project;

namespace _15._7
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Console.ReadLine();
            String filename = "test" + n + ".csv";
            try
            {
                StreamReader streamReader = new StreamReader(filename);
                HashSet<Point> set = new HashSet<Point>();

                while (!streamReader.EndOfStream)
                {
                    String a = streamReader.ReadLine();

                    String[] arr = a.Split(';');
                    if (arr.Length != 3)
                    {
                        Console.WriteLine("Некорректный формат");
                        return;
                    }


                    int x = int.Parse(arr[0]);
                    int y = int.Parse(arr[1]);
                    Point p1 = new Point(x, y);
                    p1.setColor(arr[2]);
                    set.Add(p1);




                }

                foreach (var p1 in set)
                {
                    Console.WriteLine(p1.ToString());
                }


            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не существует");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
        }
    }
}
