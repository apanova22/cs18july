using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
     public class Point
    {
       public int x;
        public int y;

        public static double distanceBetween(double Xa, double Ya, double Xb, double Yb)
        {
            double AB;
            AB = Math.Sqrt(((Xb - Xa) * (Xb - Xa)) + ((Yb - Ya) * (Yb - Ya)));
            
            return AB;
        }
        public static double distanceBetween(Point a, Point b)
        {
            double AB;
            AB = Math.Sqrt(((b.x - a.x) * (b.x - a.x)) + ((b.y - a.y) * (b.y - a.y)));

            return AB;
        }

        public double distanceTo(int Xb, int Yb)
        {
            double AB;
           
            AB = Math.Sqrt(((Xb - this.x) * (Xb - this.x)) + ((Yb - this.y) * (Yb - this.y)));

            return AB;
        }
        public double distanceTo(Point a)
        {
            double AB;
            AB = Math.Sqrt(((this.x - a.x) * (this.x - a.x)) + ((this.y - a.y) * (this.y - a.y)));

            return AB;
        }
    }
}
