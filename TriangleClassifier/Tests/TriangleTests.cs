using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            Triangle myTri = new Triangle(1.5, 1.5, 1.5);
            Assert.IsTrue(myTri.IsValidTriangle());
            myTri = new Triangle(3, 4, 4);
            Assert.IsTrue(myTri.IsValidTriangle());
            myTri = new Triangle(4.4, 7.3, 9.1);
            Assert.IsTrue(myTri.IsValidTriangle());
            myTri = new Triangle(4, 6, 11);
            Assert.IsFalse(myTri.IsValidTriangle());
        }
    }
}