using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Models
{
    internal class Rectangular : Figure
    {


        internal double Width { get; set; }

        internal double Length { get; set; }



        public Rectangular(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}
