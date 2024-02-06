using Basic.Entities;
using Basic.Services;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Date (dd/MM/yyyy hh:mm): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Contract value: ");
        double total = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter number of installments: ");
        int installments = int.Parse(Console.ReadLine());

        Contract contract = new Contract(number, date, total);

        InstallmentService installmentService = new InstallmentService(installments, new IPayPalTaxService());

        Console.WriteLine();
        Console.WriteLine("Installments: ");
        Console.WriteLine();

        installmentService.PaymentInstallmentValue(contract);

        foreach (Installment installment in contract.installment)
        {
            Console.WriteLine(installment);
        }

    }
}


