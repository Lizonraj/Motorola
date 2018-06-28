using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using Geometry.Shapes;

namespace Geometry.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Extreme_Point_Condition_Not_Satisfies_Should_Return_False()
        {
            Rectangle R1 = new Rectangle(3, 2, 6, 4);
            Rectangle R2 = new Rectangle(8, 2, 11, 4);
            CheckRectangleIntsection CRI = new CheckRectangleIntsection();
            Assert.AreEqual(false, CRI.DoesIntersect(R1, R2));

        }

        [TestMethod]
        public void Extreme_Point_Condition_Satisfies_Should_Return_True()
        {
            Rectangle R1 = new Rectangle(3, 2, 6, 4);
            Rectangle R2 = new Rectangle(5, 4, 8, 6);
            CheckRectangleIntsection CRI = new CheckRectangleIntsection();
            Assert.AreEqual(true, CRI.DoesIntersect(R1, R2));

        }
    }
}
