using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);

            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("2) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("2) DayOfYear: " + d.DayOfYear);
            //todos os tipos de date



            //formatação 

            using System.Globalization;

namespace Basic
    {
        class Program
        {
            static void Main(string[] args)
            {
                DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

                //convertendo o date time para string e colocando em long  "quarta-feira, 15 de agosto de 2001"
                Console.WriteLine(d.ToLongDateString());

                //imprime o horario
                Console.WriteLine(d.ToLongTimeString());

                //data em formato resumido
                Console.WriteLine(d.ToShortDateString());

                //hora e minuto
                Console.WriteLine(d.ToShortTimeString());

                //formato padrao
                Console.WriteLine(d.ToString());

                //mascara de formatacao
                Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));

                //imprimir milisegundos
                Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            }
        }
    }
}
    }
}