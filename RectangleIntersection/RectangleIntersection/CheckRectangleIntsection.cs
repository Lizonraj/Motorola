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
            //2 Rectangles would not intersect each other if the vertices are not touching each other
            //they are side to each other or placed top and bottom of each other
            if (R1.X1 < R2.X2 && R2.X2 > R1.X1 && R1.Y1 < R2.Y2 && R1.Y2 > R2.Y1)
            {
                return false;
            }

            //If above condition doesn't satisfy then, the rectangle are overlapped as either one of the vertices are inside the other
            return true;
        }
    }
}
