namespace Basic.Services
{
    class IPayPalTaxService : IPaymentService
    {
        public double Interest(double amount)
        {
            return amount * 0.01;
        }
        public double Tax(double amount) 
        { 
            return amount * 0.02;
        }
    }
}
