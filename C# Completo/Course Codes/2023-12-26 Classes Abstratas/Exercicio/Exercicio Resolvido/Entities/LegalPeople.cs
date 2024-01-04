
namespace Basic.Entities
{
    class LegalPeople : People
    {
        public int EmployeeNumber { get; set; }

        public LegalPeople(string name, double annualIncome, int employeeNumber) : base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Impost()
        {
            double EmployeeQuantity = (EmployeeNumber <= 10) ? 0.16 : 0.14;

            return AnnualIncome * EmployeeQuantity;
        }
    }
}
