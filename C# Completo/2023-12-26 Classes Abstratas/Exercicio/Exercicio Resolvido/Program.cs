using Basic.Entities;
using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());


                switch (ch)
                {
                    case 'i':

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Anual Icome: ");
                        double icome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Health expenditures: ");
                        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                       
                        list.Add(new PhysicalPeople(name, icome, health));

                        break;

                    case 'c':

                        Console.Write("Name: ");
                        name = Console.ReadLine();

                        Console.Write("Anual Icome: ");
                        icome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Number of employees: ");
                        int employees = int.Parse(Console.ReadLine());

                        list.Add(new LegalPeople(name, icome, employees));

                        break;
                }

                Console.WriteLine();
            }
            double sum = 0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach (People people in list)
            {
                sum += people.Impost();
                Console.WriteLine(people.Name + ": $ " + people.Impost().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}