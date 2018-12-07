using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
     public class Point
    {
       private int x;
        private int y;
         private String color;
         public override int GetHashCode()
        {
           
             int a = x + 31 * y;
             return a;
     }
        public Point()
        {
            Console.WriteLine("Constructor called");
        }
        public Point(int x, int y)
        {
            Console.WriteLine("Counstructor 2 called");
                this.x=x;
            this.y = y;
        }
        public void setCoordinates(int px, int py)
        {
            this.x = px;
            this.y = py;
        }
        
        public void setColor(String a)
        {
            this.color = a;
        }

        public static double distanceBetween(double Xa, double Ya, double Xb, double Yb)
        {
            
            double AB = Math.Sqrt(((Xb - Xa) * (Xb - Xa)) + ((Yb - Ya) * (Yb - Ya)));
            
            return AB;
        }
        public static double distanceBetween(Point a, Point b)
        {
           
            double AB = Math.Sqrt(((b.x - a.x) * (b.x - a.x)) + ((b.y - a.y) * (b.y - a.y)));

            return AB;
        }

        public double distanceTo(int Xb, int Yb)
        {
           
           
             double AB = Math.Sqrt(((Xb - this.x) * (Xb - this.x)) + ((Yb - this.y) * (Yb - this.y)));

            return AB;
        }
        public double distanceTo(Point a)
        {
            
           double AB = Math.Sqrt(((this.x - a.x) * (this.x - a.x)) + ((this.y - a.y) * (this.y - a.y)));

            return AB;
        }

        public override bool Equals(Object other)

        {    if (other == null)
            {
                return false;
            }
            if (GetType() != other.GetType())
            {
                return false;
            }
            Point point = (Point)other;
           
           
            if (x == point.x && y == point.y && color==point.color)
            {
                return true;
            }
            if (this == other)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
           String result= "("+x+";"+y+")";
            return result;

        }
    }
}
