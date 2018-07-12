using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
{
    static void Main(string[] args)
    {
        String firstName, lastName;
        firstName = Console.ReadLine();
        lastName = Console.ReadLine();
        Console.WriteLine("Меня зовут {0},{1},{0}", lastName, firstName);
    }
}
}

