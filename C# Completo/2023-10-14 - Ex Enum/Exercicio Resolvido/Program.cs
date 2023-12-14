
using Basic.Entities;
using System.Globalization;
using System;
using Basic.Entities.Enums;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente data:");
            Console.Write("Name: ");
            string ClientName = Console.ReadLine();
            Console.Write("Email: ");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime Clientdate = DateTime.Parse(Console.ReadLine());

            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(ClientName, ClientEmail, Clientdate);

            Order order = new Order(client, status);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string ProdutName = Console.ReadLine();
                Console.Write("Product Price: ");
                double ProdutPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int ProductQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product product = new Product(ProdutName, ProdutPrice);
                orderItem = new OrderItem(ProductQuantity, product);
                order.addItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
        }
    }
}