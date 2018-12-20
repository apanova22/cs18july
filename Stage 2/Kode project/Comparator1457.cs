using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
    public class Comparator1457 : Comparer<Point>
    {

        
       public Point c = new Point();
        
        public override int Compare(Point a, Point b)
        {
            double n =Point.distanceBetween(a,c);
            double n1 = Point.distanceBetween(b,c);
            if (n < n1)
            {
                int u = -1;
                return u;
            }
            else if (n== n1)
            {
                int p = 0;
                return p;
            }
            else
            {
                int k = 1;
                return k;
                throw new NotImplementedException();
            }
        }
    }
}
