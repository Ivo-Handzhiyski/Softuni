using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    class Box
    {
        public Box(double height, double lenght, double width)
        {
            this.Height = height;
            this.Lenght = lenght;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.Height;
            }
            private set
            {
                if (value > 0)
                {
                    this.Height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }
        public double Lenght
        {
            get
            {
                return this.Lenght;
            }
            private set
            {
                if (value > 0)
                {
                    this.Lenght = value;
                }
                else
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
            }
        }
        public double Width
        {
            get
            {
                return this.Width;
            }
            private set
            {
                if (value > 0)
                {
                    this.Width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }

        public override string ToString()
        {
            double surfaceArea = 2 * this.Height + 2 * this.Lenght + 2 * this.Width;
            double volume = this.Height * this.Lenght * this.Width;
            double LatArea = 2 * this.Lenght + 2 * this.Width;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {surfaceArea:f2}");
            sb.AppendLine($"Lateral Surface Area - {LatArea:f2}");
            sb.AppendLine($"Volume - {volume:f2}");

            return sb.ToString();
        }

    }
}
