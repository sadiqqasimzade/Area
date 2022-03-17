using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    internal class Square : Figure
    {

        internal double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalcArea()
        {
            return Side * Side;
        }
    }
}
