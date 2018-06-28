using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry.Interfaces;
using Geometry.Shapes;

namespace Geometry
{
    public class CheckRectangleIntsection : IDetectIntersection
    {
        public bool DoesIntersect(Rectangle R1, Rectangle R2)
        {
            //2 rectangles does not intersect if they are side to side (i.e either completly in right/left )
            if(R1.X1 > R2.X2 || R2.X1 > R1.X2)
            {
                return false;
            }

            //if 2 rectangles are on top/bottom of each other
            if(R1.Y1 > R2.Y2 || R2.Y1 > R2.Y2)
            {
                return false;
            }

            return true;
        }
    }
}
