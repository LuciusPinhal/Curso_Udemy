using Basic.Entities;
using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtc> produtc = new List<Produtc>();

            Console.Write("Enter the nuber of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data");

                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (ch)
                {
                    case 'c':
                        produtc.Add(new Produtc(name, price));
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        produtc.Add(new UsedProduct(name, price, date));
                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        produtc.Add(new ImportedProduct(name, price, fee));
                        break;

                    default:
                        Console.WriteLine("Caractere inválido.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Produtc prod in produtc)
            {
                Console.WriteLine(prod.priceTag());
            }

        }
    }
}