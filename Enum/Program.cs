using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        public enum Weather
        {
            Hot,
            Cool,
            Cold
        }
        static void Main(string[] args)
        {
            Console.Write("The temperature today is ");
            double a = double.Parse(Console.ReadLine());
            if (a < 18) Console.Write(Weather.Cold);
            else if (a > 30) Console.Write(Weather.Hot);  
            else Console.Write(Weather.Cold);
            Console.ReadKey();
        }
    }
}
