namespace Basic.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Impost();

    }
}
