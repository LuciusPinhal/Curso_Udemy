using Basic.Entities;
using Basic.Entities.Enums;


namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order 
            {
               Id = 1080,
               Moment = DateTime.Now,
               Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            //transformando enum em string
            string txt = OrderStatus.PendingPayment.ToString();
            //transformando string em  enum 
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

            //representação em UML

        }
    }
}