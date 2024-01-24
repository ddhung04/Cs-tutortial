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
        public int OrderId { get; set; } = 0;
        public int Cost { get; set; }
        public IPaymentMethod PaymentMethods { get; set; }
        public string OrderStatus = "Unpaid";

        public Order(string NameProduct, string Description, int OrderId, int Cost, IPaymentMethod PaymentMethod)
        {
            this.NameProduct = NameProduct;
            this.Description = Description;
            this.OrderId = OrderId;
            this.Cost = Cost;
            this.PaymentMethods = PaymentMethod;
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
                order.PaymentMethods?.ProcessPayment(order);
                order.OrderStatus = "Paid";
        }
    }

    internal class Program
    {
        // show ra list order
        static void ShowOrder(List<Order> orderlist)
        {
            foreach(var order in orderlist)
            {
                Console.WriteLine($"Name: {order.NameProduct}, Description: {order.Description}, OrderId: {order.OrderId}, Cost: {order.Cost}, PaymentMethod: {order.PaymentMethods.GetType().Name}, Status: {order.OrderStatus}");
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
            Order myOrder = new Order("IP15", "Fake", 2512, 2000000, new CreditCardPayment());
            List<Order> orderList = Order.GetOrderList();

            ShowOrder(orderList);

            Process(myOrder);

            ShowOrder(orderList);

            Console.ReadKey();
        }
    }
}
