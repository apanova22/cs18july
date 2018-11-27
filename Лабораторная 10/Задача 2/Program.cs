using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            if (x < 0 && y<0)
            {
                Console.WriteLine("Левая точка прямоугольника должна иметь неотрицательные координаты");
                return;
            }
            StreamWriter writer = new StreamWriter("example.html");
            if (width <= 0)
            {
                Console.WriteLine("Ширина прямоугольника должна быть положительной");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine("Высота прямоугольника должна быть положительной");
                return;
            }

            writer.Write(@"<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf - 8""/>
</head>
<body>
    <h1> Мой первый векторный рисунок </h1>

    <svg>
  <rect x=""{0}"" y=""{1}"" width=""{2}"" height=""{3}""
stroke = ""blue""

        stroke-width = ""2"" fill = ""red"" />
</ svg >
</body>
</html> ", x, y, width, height);
            writer.Close();
            System.Diagnostics.Process.Start("example.html");
        }

    }
}
