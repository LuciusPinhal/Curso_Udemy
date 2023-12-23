namespace Basic.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) 
        {
            AdditionalCharge = additionalCharge;
        }


        /// <summary>
        /// Pagamento do funcionario tercerizado
        /// </summary>
        /// <returns>110% mais o pagamento adcional</returns>
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
