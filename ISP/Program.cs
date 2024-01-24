using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IMovable
    {
        void Move();
    }

    public interface ISpeedDisplay
    {
        void DisplaySpeed();
    }

    public class Car : IMovable, ISpeedDisplay
    {
        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }

        public void DisplaySpeed()
        {
            Console.WriteLine("Car speed is displayed...");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // do something
        }
    }
}
