using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a hora Atual? :");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia! Agora são: " + hora + " Horas");
            }
            else if (hora >= 12 && hora <= 18)
            {
                Console.WriteLine("Bom tarde! Agora são: " + hora + " Horas");
            }
            else
            {
                Console.WriteLine("Bom Noite! Agora são: " + hora + " Horas");
            }
        }
    }
}
