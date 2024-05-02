using Basic.Model.Entities;
using Basic.Model.Enums;
using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Cicle() { Radius = 2.0, Color = Color.white };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}