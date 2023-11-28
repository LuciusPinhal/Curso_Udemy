using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Employees
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        /// <summary>
        /// Aumentar Salario de acordo com a porcentagem
        /// </summary>
        /// <param name="percentage">Definida pelo usuario</param>
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100.0);
        }

        public override string ToString()
        {
            return "Id: " + Id
                + ", Name: "
                + Name
                + ", Salary: "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

