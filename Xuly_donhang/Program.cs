using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xuly_donhang
{
    public class Order
    {
        public static readonly List<Order> OrderList = new List<Order>();
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public IPaymentMethod PaymentMethod { get; set; }
        public string OrderStatus = "Unpaid";

        public Order(string NameProduct, string Description, int OrderId, IPaymentMethod PaymentMethod)
        {
            this.NameProduct = NameProduct;
            this.Description = Description;
            this.OrderId = OrderId;
            this.PaymentMethod = PaymentMethod;
            OrderList.Add(this); // lưu vào List ngay khi khởi tạo
        }

        public static List<Order> GetOrderList()
        {
            return OrderList;
        }

    }

    // Các phương thức thanh toán _ có thể mở rộng _
    public interface IPaymentMethod
    {
        void ProcessPayment(Order order);
    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"The order {order.OrderId} has been paid by Credit Card");
        }
    }
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"The order {order.OrderId} has been paid by PayPal");

        }
    }
    // mở rộng nếu cần

    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
                order.PaymentMethod?.ProcessPayment(order);
                order.OrderStatus = "Paid";
        }
    }

    internal class Program
    {
        // show ra list order
        static void ShowOrder(List<Order> orderlist)
        {
            Console.WriteLine($"{"Name",-15} {"Description",-15} {"OrderId",-10} {"PaymentMethod",-20} {"Status",-10}");
            foreach (var order in orderlist)
            {
                Console.WriteLine($"{order.NameProduct,-15} {order.Description,-15} {order.OrderId,-10} {order.PaymentMethod.GetType().Name,-20} {order.OrderStatus,-10}");
            }
        }

        // xử lý thanh toán đơn hàng
        static void Process(Order order)
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessOrder(order);
        }

        static void Main(string[] args) 
        {
            List<Order> orderList = Order.GetOrderList();
            while (true)
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Order");
                Console.WriteLine("2. Pay");
                Console.WriteLine("3. ViewOrders");
                Console.WriteLine("4. Exit");
                Console.Write("Please Choice (1-4): ");
                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Name Product: "); string name = Console.ReadLine();
                        Console.Write("Description: "); string description = Console.ReadLine();
                        Console.WriteLine("PaymentMethods: 1.<Credit Card> or  2.<PayPal>"); // mở rộng nếu cần 
                        string x = Console.ReadLine();
                        Random random = new Random();
                        int id = random.Next(1, 10000);

                        // phương thức thanh toán
                        Order newOrder;
                        switch(x) 
                        {
                            case "1":
                                newOrder = new Order(name, description, id, new CreditCardPayment());
                                break;
                            case "2":
                                newOrder = new Order(name, description, id, new PayPalPayment());
                                break;
                            // mở rộng nếu cần
                        }

                        Console.WriteLine($"You Order ID: {id}");
                        Console.WriteLine("Successful Order");
                        break;

                    case "2":
                        Console.Write("OrderID: ");
                        if (int.TryParse(Console.ReadLine(), out int ID))
                        {
                            Order orderToPay = orderList.Find(o => o.OrderId == ID);
                            if (orderToPay != null)
                            {
                                Process(orderToPay);
                                Console.WriteLine("Successful");
                            }
                            else
                            {
                                Console.WriteLine("Not Found ID");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;

                    case "3":
                        ShowOrder(orderList);
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
    }
}
