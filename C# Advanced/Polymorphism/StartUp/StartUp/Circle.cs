using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }


        public override double CalculateArea()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * this.Radius * this.Radius;
        }
        public sealed override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
