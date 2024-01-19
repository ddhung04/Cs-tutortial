using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_thu_vien
{
    internal class Program
    {
        static List<Order> orders = new List<Order>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Muon Sach");
                Console.WriteLine("2. Tra Sach");
                Console.WriteLine("3. Danh Sach Da Muon");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang(1-4): ");
                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MuonSach();
                        break;
                    case "2":
                        TraSach();
                        break;
                    case "3":
                        DanhSach();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Khong hop le. Vui long chon lai.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void MuonSach()
        {
            Console.Write("MSV: ");
            string MSV = Console.ReadLine();
            Console.Write("Muon Sach: ");
            string name = Console.ReadLine();

            Order newOrder = new Order
            {
                ID = Guid.NewGuid(),
                MSV = MSV,
                name = name,
            };

            orders.Add(newOrder);
            Console.WriteLine("ID: " + newOrder.ID);
            Console.WriteLine("Da Muon Thanh Cong");
        }

        static void TraSach()
        {
            Console.Write("Nhap ID: ");
            Guid ID = Guid.Parse(Console.ReadLine());
            Order orderToDelete = orders.Find(o => o.ID == ID);
            if (orderToDelete != null)
            {
                orders.Remove(orderToDelete);
                Console.WriteLine("Da Tra Thanh Cong.");
            }
            else
            {
                Console.WriteLine("Khong tim thay ID.");
            }
        }

        static void DanhSach()
        {
            Console.WriteLine("Danh Sach Da Muon:");
            if (orders.Count == 0)
            {
                Console.WriteLine("Khong Co Ai Muon");
            }
            else
            {
                foreach (var order in orders)
                {
                    Console.WriteLine($"ID: {order.ID}");
                    Console.WriteLine($"MSV: {order.MSV}");
                    Console.WriteLine($"Sach Da Muon: {order.name}");
                    Console.WriteLine("------------------------");
                }
            }
        }

        public class Order
        {
            public Guid ID { get; set; }
            public string MSV { get; set; }
            public string name { get; set; }
        }
    }
}
