using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 7.0, "Red", true);
            Console.WriteLine(rectangle.ToString());
            Console.ReadLine();
            Square square = new Square(5.0, "Red", true);
            Console.WriteLine(square.ToString());
            square.SetSide(7.0);
            Console.WriteLine(square.ToString());
            double area = square.GetArea();
            double perimeter = square.GetPerimeter();
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.ReadKey();
        }
    }
}
