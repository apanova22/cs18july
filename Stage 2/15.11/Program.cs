using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kode_project;

namespace _15._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator1457 comparator1457 = new Comparator1457();
            List<Point> points = new List<Point>();
            points.Add(new Point(6,1));
            points.Add(new Point(1,2));
            points.Add(new Point(3, 2));
            points.Add(new Point(7, 3));
            points.Add(new Point(5, 4));
            points.Add(new Point(2, 5));
            points.Add(new Point(3, 7));
            points.Add(new Point(8, 7));
         
            comparator1457.c.setCoordinates(3,3);
            points.Sort(comparator1457);
          
            
            Console.WriteLine(String.Join(",", points));

        }
    }
}
