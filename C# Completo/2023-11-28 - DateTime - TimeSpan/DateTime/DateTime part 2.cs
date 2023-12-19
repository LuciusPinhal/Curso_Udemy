using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2000, 10, 15);
            DateTime d6 = new DateTime(2000, 10, 18);

            //adicinar duas horas
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            //adcionar uma semana
            DateTime d4 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);


            //calcular diferença entre dias, estou subtraindo a data d6 da data d 
            TimeSpan t = d6.Subtract(d);
            Console.WriteLine(t);

            //calcular data de vencimento 

        }
    }
}