using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea__()
        {
            double redius = 7;
            Circle c = new Circle(redius);
            var result = c.GetArea();
            Assert.AreEqual("153.94", result.ToString("###,###.##"));
        }
        [TestMethod]
        public void GetPerimetor__()
        {
            double redius = 7;
            Circle c = new Circle(redius);
            var result = c.GetPerimetor();
            Assert.AreEqual("43.98", result.ToString("###,###.##"));
        }
    }
}
