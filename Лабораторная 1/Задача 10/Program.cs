using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String user, pass, host, port,db;
            user = Console.ReadLine();
            pass = Console.ReadLine();
            host= Console.ReadLine();
            port = Console.ReadLine();
            db = Console.ReadLine();
            Console.WriteLine("User ID={0};Password={1};"+"\n"+"Host={2};Port={3};Database={4};",user,pass,host,port,db);
        }
    }
}
