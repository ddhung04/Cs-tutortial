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
            Square square = new Square(5.0, "Red", true);
            Console.WriteLine(square.ToString());
            square.SetSide(7.0);
            Console.WriteLine(square.ToString());
            Console.ReadKey();
        }
    }
}
