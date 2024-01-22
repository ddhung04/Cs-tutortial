using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    public class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public double GetSide()
        {
            return length;
        }

        public void SetSide(double side)
        {
            width = side;
            length = side;
        }

        public override string ToString()
        {
            return $"Square[side={GetSide()}, color={GetColor()}, filled={IsFilled()}]";
        }
    }
}
