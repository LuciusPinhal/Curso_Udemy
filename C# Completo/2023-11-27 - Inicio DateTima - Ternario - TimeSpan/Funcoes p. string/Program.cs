using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            string origem = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = origem.ToUpper();
            string s2 = origem.ToLower();
            string s3 = origem.Trim();
            string s4 = origem.Trim().ToLower();

            //pode ser tanto string ou valor
            int n1 = origem.IndexOf("bc");
            int n2 = origem.LastIndexOf("bc");

            //cortar string
            string s5 = origem.Substring(3);
            string s6 = origem.Substring(3, 5);

            //substriuir string
            //trpcar todo caracter a por x
            string s7 = origem.Replace('a', 'x');

            string s8 = origem.Replace("abc", "Xy");


            //verificar se a string esta vazia

            bool b1 = String.IsNullOrEmpty(origem);
            bool b2 = String.IsNullOrWhiteSpace(origem);

            Console.WriteLine("Original: -" + origem + "- ");
            Console.WriteLine("ToUpper: -" + s1 + "- ");
            Console.WriteLine("Trim: -" + s2 + "- ");
            Console.WriteLine("ToLower.Trim: -" + s3 + "- ");

            Console.WriteLine("IndexOf: (bc) " + n1);
            Console.WriteLine("LastIndexOf: (bc) " + n2);

            Console.WriteLine("Substring: -" + s5 + "- ");
            Console.WriteLine("Substring(3, 5): -" + s6 + "- ");
            Console.WriteLine("Replace: -" + s7 + "- ");
            Console.WriteLine("Replace: -" + s8 + "- ");


            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);




        }
    }
}