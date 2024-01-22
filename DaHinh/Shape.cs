using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    public abstract class Shape
    {
        protected string color;
        protected bool filled;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public bool IsFilled()
        {
            return filled;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Shape[color={GetColor()}, filled={IsFilled()}]";
        }
    }
}
