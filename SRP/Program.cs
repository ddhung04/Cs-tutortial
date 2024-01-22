using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    abstract class Employee
    {
        public abstract void working();
        public abstract void Show();
    }

    class Seller : Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Seller(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public override void working()
        {
            Console.WriteLine("ban hang");
        }
        public override void Show()
        {
            Console.WriteLine($"Ho Ten: {Name}\nID: {ID}");
        }
    }

    class Manage : Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Manage(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public override void working()
        {
            Console.WriteLine("quan ly");
        }
        public override void Show()
        {
            Console.WriteLine($"Ho Ten: {Name}\nID: {ID}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee seller = new Seller("Duy Hung", "2512");
            seller.Show();
            seller.working();
            Console.ReadKey();
        }
    }
}
