using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea__()
        {
            double height = 8;
            double width = 6;
            Triangle c = new Triangle(height, width);
            var result = c.GetArea();
            Assert.AreEqual("24", result.ToString("###,###.##"));
        }
        [TestMethod]
        public void GetPerimetor__()
        {
            double height = 8;
            double width = 6;
            Triangle c = new Triangle(height, width);
            var result = c.GetPerimetor();
            Assert.AreEqual("24", result.ToString("###,###.##"));
        }
    }
}
