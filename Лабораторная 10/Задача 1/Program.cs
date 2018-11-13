using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int sw = int.Parse(Console.ReadLine());
            if (cx - r < 0)
            {
                Console.WriteLine("Левая точка круга должна иметь неотрицательные координаты");
                return;
            }
            StreamWriter writer = new StreamWriter("example.html");
            writer.Write(@"<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf - 8""/>
</head>
<body>
    <h1> Мой первый векторный рисунок </h1>

    <svg width = ""800"" height = ""600"">
        <circle cx = ""{0}"" cy = ""{1}"" r = ""{2}"" stroke = ""green""

        stroke-width = ""{3}"" fill = ""yellow"" />
    </svg>
</body>
</html> "".",cx,cy,r,sw);
            writer.Close();
          System.Diagnostics.Process.Start("example.html");
        }
        
    }
}
