using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double length;

        public Rectangle()
        {
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double length)
        {
            this.length = length;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public override double GetArea()
        {
            return GetLength() * GetWidth();
        }

        public override double GetPerimeter()
        {
            return (GetWidth() + GetLength()) * 2;
        }

        public override string ToString()
        {
            return $"Rectangle[width={GetWidth()}, length={GetLength()}, color={GetColor()}, filled={IsFilled()}]";
        }
    }
}
