using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void GetArea__()
        {
            double height = 5;
            double width = 4;
            Rectangle c = new Rectangle(height,width);
            var result = c.GetArea();
            Assert.AreEqual("20", result.ToString("###,###.##"));
        }
        [TestMethod]
        public void GetPerimetor__()
        {
            double height = 5;
            double width = 4;
            Rectangle c = new Rectangle(height, width);
            var result = c.GetPerimetor();
            Assert.AreEqual("18", result.ToString("###,###.##"));
        }
    }
}
