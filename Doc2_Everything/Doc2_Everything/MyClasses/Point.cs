using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc2_Everything.MyClasses
{
    //make sure ytour classes are public yo
    public class Point
    {
        // iVars that we won't worry about later on.
        int x;
        int y;

        //setters 
        // sets the iVar to a thing when the method is called. Duh. Returns nothing.
        public void setX(int passedX)
        {
            this.x = passedX;
        }
        public void setY(int passedY)
        {
            this.y = passedY;
        }

        //getters
        // returns an INT with the current iVar value. Duh.
        public int geX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }

        //returns a STRING with the info on the point.
        public string PointInfo()
        {
            string info = "The point is at (" + x + "," + y + ")";
            return info;
        }

        //distance from the origin
        public double DistanceFromOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        //distance our point is from another point.
        //IMPORTANT. We have point in there because the thing we're passing to this method is
        // another point. Another class! Well, instance of this class. But yeah! Programming!
        public double distanceFromAnotherPoint(Point passedPoint)
        {
            double firstPart = (x - passedPoint.x) * (x - passedPoint.x);
            double secondPart = (this.getY() - passedPoint.getY()) * (this.y - passedPoint.y);

            return Math.Sqrt(firstPart + secondPart);
        }

    } // end class
} // end namespace
