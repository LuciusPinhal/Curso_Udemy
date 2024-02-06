namespace Basic.Services
{
    interface IPaymentService
    {
        double Tax(double amount);
        double Interest(double amount);
    }
}
