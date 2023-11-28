using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ternarioDesconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            double desconto;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
            Console.WriteLine(ternarioDesconto);
        }
    }
}