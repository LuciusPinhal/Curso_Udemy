using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

// Classes, Objetos , atributos
//Classe é a definição do tipo Ex. Triangulo.cs
// obj são instancias da classe Ex. Obj triangulo X, Y
//cada um desses dados do tringulo são os atributos  Ex.  (x.A; x.b; ....y.A )
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Informe as medidas do triangulo X: ");
            //criamos uma classe triangulo e estamos instanciando os objetos do trinagulo por ponteiro
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Informe as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("áreas com tamanhos iguais");
            }
        }
    }
}
