using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basic.Entities
{
    class PhysicalPeople : People
    {
        public double HealthExpenses { get; set; }

        public PhysicalPeople(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Impost()
        {
          
            double taxIncomeRate = (AnnualIncome <= 20000) ? 0.15 : 0.25;       
            double healthDeduction = (HealthExpenses > 0) ? (HealthExpenses * 0.50) : 0;

            return (AnnualIncome * taxIncomeRate) - healthDeduction;
        }
    }
}
