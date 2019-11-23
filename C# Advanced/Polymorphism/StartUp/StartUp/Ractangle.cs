using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    class Ractangle : Shape
    {
        public Ractangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;

        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return this.Height * 2 * this.Width * 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Height * this.Width;
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
