using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача7
{
    class Program
    {
        static void Main(string[] args)
        {
            String id;
            id = Console.ReadLine();
            
            Console.WriteLine("SELECT first_name, last_name, group\n" +
 "FROM students WHERE student_id= {0}",id) ;
           
        }
    }
}
