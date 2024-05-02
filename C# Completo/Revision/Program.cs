using Basic.Model.Entities;

using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Nome ");
                string n = Console.ReadLine();

                Console.Write("senha ");
                string p = Console.ReadLine();

                Console.Write("Descricao ");
                string d = Console.ReadLine();

                Filho f = new Filho(n, p, d);
                Heranca pai = new Heranca();

                pai.AddItens(n, p);

                Console.WriteLine(f);

                Console.WriteLine("--------------------------");

                Console.WriteLine(pai);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}