using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boa partica
            // armazenar as datas em formato UTC
            //exibe para o usuario a data local TIme

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //quando voce nao expecifica se e local ou utc ele adciona 3 horas e subitrai 3 horas
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1.Kind: " + d1.Kind);
            //nao modifica
            Console.WriteLine("d1 To Local: " + d1.ToLocalTime());

            //ele adciona 3 horas a mais
            Console.WriteLine("d1 UTF: " + d1.ToUniversalTime());
            Console.WriteLine();

            // Data UTC 
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2.Kind: " + d2.Kind);

            //ele volta 3 horas a mais
            Console.WriteLine("d2 To Local: " + d2.ToLocalTime());

            //nao modifica
            Console.WriteLine("d2 UTF: " + d2.ToUniversalTime());


            // Lembre-se que o date time é local
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