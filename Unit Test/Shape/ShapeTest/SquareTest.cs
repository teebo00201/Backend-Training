using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void GetArea__()
        {
            double side = 7;
            Square c = new Square(side);
            var result = c.GetArea();
            Assert.AreEqual("49", result.ToString("###,###.##"));
        }
        [TestMethod]
        public void GetPerimetor__()
        {
            double side = 7;
            Square c = new Square(side);
            var result = c.GetPerimetor();
            Assert.AreEqual("28", result.ToString("###,###.##"));
        }
    }
}
