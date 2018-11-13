using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kode_project
{
    public class Range
    {
        public int from;
        public int to;

        public void Init(int A, int B)
        {
            this.from = A;
            this.to = B;
        }

        public static bool HasIntersection(int leftA, int leftB, int rightA, int rightB)
        {


            bool result;
            if (leftA < leftB && rightA < rightB)
            {
                if (leftA < rightA)
                {
                    if (leftB < rightA)
                    {
                        result = false;
                    }

                    else if (leftB > rightA && leftB < rightB)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }


                }

                else
                {
                    if (rightB < leftA)
                    {
                        result = false;
                    }
                    else if (rightB > leftA && rightB > leftB)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }

                }
                return result;
            }
            else
            {
                ArgumentException e = new ArgumentException("Значение А должно быть меньше В");
                throw e;
            }



        }
        public static bool HasIntersection(Range left, Range right)
        {

            bool result;
            if (left.from < left.to && right.from < right.to)  //(leftA < leftB && rightA < rightB)
            {
                if (left.from < right.from)
                {
                    if (left.to < right.from)
                    {
                        result = false;
                    }

                    else if (left.to > right.from && left.to < right.to)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }


                }

                else
                {
                    if (right.to < left.from)
                    {
                        result = false;
                    }
                    else if (right.to > left.from && right.to > left.to)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }

                }
                return result;
            }
            else
            {
                ArgumentException e = new ArgumentException("Значение А должно быть меньше В");
                throw e;
            }

        }
        public bool Intersects(int leftA, int leftB)

        {
            bool result;
            if (leftA < leftB && this.from < this.to)
            {
                if (leftA < this.from)
                {
                    if (leftB < this.from)
                    {
                        result = false;
                    }

                    else if (leftB > this.from && leftB < this.to)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }


                }

                else
                {
                    if (this.to < leftA)
                    {
                        result = false;
                    }
                    else if (this.to > leftA && this.to > leftB)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }

                }
                return result;
            }
            else
            {
                ArgumentException e = new ArgumentException("Значение А должно быть меньше В");
                throw e;
            }
        }
        public bool Intersects(Range left)

        {

            bool result;
            if (left.from < left.to && this.from < this.to)  
            {
                if (left.from < this.from)
                {
                    if (left.to < this.from)
                    {
                        result = false;
                    }

                    else if (left.to > this.from && left.to < this.to)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }


                }

                else
                {
                    if (this.to < left.from)
                    {
                        result = false;
                    }
                    else if (this.to > left.from && this.to > left.to)
                    {
                        result = true;
                    }
                    else
                    {
                        result = true;
                    }

                }
                return result;
            }
            else
            {
                ArgumentException e = new ArgumentException("Значение А должно быть меньше В");
                throw e;
            }
        }
        public override bool Equals(Object other)

        {
            if (other == null)
            {
                return false;
            }
            if (GetType() != other.GetType())
            {
                return false;
            }
            Range range = (Range)other;


            if (from == range.from && to == range.to )
            {
                return true;
            }
            if (this == other)
            {
                return true;
            }
            return false;
        }
    }
}
