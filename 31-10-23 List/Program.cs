using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bobes");
            list.Add("Ana");

            //ele nao sobrescreve o bob e sim coloca na posicao no bob e o bob vai para 3
            list.Insert(2, "Marcos");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: " + list.Count);
            Console.WriteLine();
            string s1 = list.Find(Teste);
            Console.WriteLine("Primeiro nome da lista que começa com A: " + s1);

            //com lambda
            string s2 = list.Find(x => x[0] == 'B');
            Console.WriteLine("Primeiro nome da lista que começa com B: " + s2);

            //Ultimo nome
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome da lista que começa com A: " + s3);

            Console.WriteLine();
            // achar posição

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição com a letra A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Utima posição com a letra A: " + pos2);

            Console.WriteLine();
            //filtrar lista 


            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //remover por posição 
            //list.RemoveAt(3);
            //remover por Nome 
            //list.Remove("Alex");

            //ele espera a posição e depois quantos elementos ele quer remover
            list.RemoveRange(2, 2);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------------------------");
            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }



            Console.WriteLine("-------------------------------------------------");





        }
        //Bool para verdadeiro ou falso
        static bool Teste(string procurar)
        {
            return procurar[0] == 'A';
        }
    }
}
