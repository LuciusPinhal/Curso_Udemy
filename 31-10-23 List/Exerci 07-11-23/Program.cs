using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered ? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> employees = new List<Employees>();

            CreateListEmployess(n, employees);

            IncreaseToSalary(employees);

            PrintEmployess(employees);

        }

        /// <summary>
        /// Criar a lista de acordo que o usuario define 
        /// </summary>
        /// <param name="n">Numero da Lista</param>
        static void CreateListEmployess(int n, List<Employees> employees)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employees employee = new Employees(Id, name, salary);
                employees.Add(employee);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Le o id e porcentagem para após chamar-lo para acresentar no salario
        /// </summary>
        /// <param name="employees"></param>
        static void IncreaseToSalary(List<Employees> employees)
        {
            Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());

            //tenho que crar um nova classe para encontrar se o id é igual 
            Employees more = employees.Find(e => e.Id == id);
            if (more != null)
            {
                Console.Write("Enter the porcentage: ");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                more.IncreaseSalary(porcentage);
            }
            else
            {
                Console.WriteLine("This id does not exist !");
            }

        }

        /// <summary>
        /// Ordenar em ordem crecente e imprimir
        /// </summary>
        static void PrintEmployess(List<Employees> employees)
        {
            Console.WriteLine();
            //deixar o id em ordem crescente 
            employees = employees.OrderBy(e => e.Id).ToList();
            Console.WriteLine("Updated list of employees: ");

            foreach (Employees obj in employees)
            {
                Console.WriteLine(obj);
            }
        }


    }
}
