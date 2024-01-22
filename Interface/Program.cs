using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IShape
    {
        double GetArea();       
        double GetPerimeter();
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Program
    {
        static void Main()
        {
            IShape rectangle = new Rectangle(5.0, 3.0);
            IShape circle = new Circle(2.5);

            Console.WriteLine($"Rectangle - Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Circle - Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");
            Console.ReadKey();
        } 
    }

}
