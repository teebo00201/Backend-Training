using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Square : IShape
    {
        private double Side;
        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimetor()
        {
            return Side * 4;
        }
    }
}
