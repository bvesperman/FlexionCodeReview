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
    public class ShapeTests
    {

        [TestMethod()]
        public void IsSideValidTest()
        {
            Assert.IsTrue(Shape.IsSideValid("1"));
            Assert.IsTrue(Shape.IsSideValid(".000001"));
            Assert.IsTrue(Shape.IsSideValid("1.00"));
            Assert.IsTrue(Shape.IsSideValid("1.11"));
            Assert.IsTrue(Shape.IsSideValid("3023492340.00"));
            Assert.IsFalse(Shape.IsSideValid("apple"));
            Assert.IsFalse(Shape.IsSideValid("-0.00"));
            Assert.IsFalse(Shape.IsSideValid("0"));
            Assert.IsFalse(Shape.IsSideValid("-5.00"));

        }
    }
}