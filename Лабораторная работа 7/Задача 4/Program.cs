using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;
            int B = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());
            

            data = Console.ReadLine();
           
            String[] arr = data.Split(' ');
            if (B < 0 || B >= arr.Length)
            {
                Console.WriteLine("Число B должно быть в интервале[0, размер массива)");
                return;
            }
            if (E < 0 || E >= arr.Length)
            {
                Console.WriteLine("Число E должно быть в интервале[0, размер массива)");
                return;
            }
            if (B < E)
            {
                while (B<=E)
                {
                    
                    Console.Write(arr[B] + " ");
                   
                    B++;



                }
            }
            else
            {
                while (E <= B)
                {

                    Console.Write(arr[E] + " ");

                    E++;



                }
            }
        }
    }
}
