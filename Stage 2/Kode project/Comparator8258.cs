using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
   public  class Comparator8258 : Comparer<int>
    {
        public int l = 6;
        public override int Compare(int x, int y)
        {
            

            if (Math.Abs(l - x) < Math.Abs(l - y))
            {
                int u = -1;
                return u;
            }
            else if (Math.Abs(l - x) == Math.Abs(l - y))
            {
                int p = 0;
                return p;
            }
            else
            {
 int k = 1;
                return k;
            }
            throw new NotImplementedException();
        }

    }
}
