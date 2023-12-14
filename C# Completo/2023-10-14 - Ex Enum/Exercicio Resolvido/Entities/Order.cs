using Basic.Entities.Enums;
using System.Text;

namespace Basic.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public Client VarClient { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(Client varClient, OrderStatus status)
        {
            Moment = DateTime.Now;
            VarClient = varClient;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void removeItem(OrderItem item)
        { 
            Item.Remove(item); 
        }
        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Item)
            {
                total += item.price * item.quantity;
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.Append(VarClient.Name);
            sb.Append(" (");
            sb.Append(VarClient.BirthDate);
            sb.Append(") - ");
            sb.AppendLine(VarClient.email);

            sb.AppendLine("Order Items: ");

            foreach (OrderItem item in Item)
            {
                sb.Append(item.Product.name);
                sb.Append(", R$");
                sb.Append(item.Product.price.ToString());
                sb.Append(", Quantity: ");
                sb.Append(item.quantity.ToString());
                sb.Append(", Subtotal: R$");
                sb.AppendLine(item.subTotal().ToString());
            }

            sb.Append("Total price: ");
            sb.Append(Total());

            return sb.ToString();
        }
    }
}
