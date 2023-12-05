using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            //Padrao ISO 8601 
            //Z indica que a data esta em UTC
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(d1);

            //ele vai voltar 3 horas, por que a data esta instaciada LOCAL
            Console.WriteLine(d2);

        }
    }
}