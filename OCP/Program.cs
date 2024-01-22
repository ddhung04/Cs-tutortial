using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public override double Area()
        {
            return 0;
        }
    }
    public class Elip : Shape
    {
        public override double Area()
        {
            return 0;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2.0);
            Console.WriteLine(circle.Area().ToString());
            Console.ReadKey();
        }
    }
}
