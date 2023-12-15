using Basic.Entities;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brow", 100.0, 500.0);
            Console.WriteLine(account.Balance);
            //dessa forma fica inacessivel par que outras acessem para aterar o Balance, porem subclasses podem altera-lo
            //account.Balance = 200;
            account.UpdateBalance(200);
            Console.WriteLine("Atualizado: " + account.Balance);

        }
    }
}