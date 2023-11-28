using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500, 10);
            p.SetNome("Tv 4K");
            Console.WriteLine(p.GetNome());




        }
    }
}
