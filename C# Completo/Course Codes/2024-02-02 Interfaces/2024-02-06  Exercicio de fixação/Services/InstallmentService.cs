using Basic.Entities;

namespace Basic.Services
{
    class InstallmentService
    {
        public int Installments { get; set; }

        private IPaymentService _paymentService;
        public InstallmentService(int installments, IPaymentService paymentService)
        {
            Installments = installments;
            _paymentService = paymentService;
        }

        public void PaymentInstallmentValue(Contract contract)
        {
            DateTime data = contract.Date;
            Installment[] installments = new Installment[Installments];

            for (int i = 0; i < Installments; i++)
            {
                double ValueInstallment = contract.TotalValue / Installments;
                double Interest = _paymentService.Interest(ValueInstallment);

                ValueInstallment = ValueInstallment + (Interest * (i + 1));

                double Tax = _paymentService.Tax(ValueInstallment);
                ValueInstallment = Tax + ValueInstallment;

                data = data.AddMonths(1);
                installments[i] = new Installment(data, ValueInstallment);
            }

            contract.installment = installments;
        }
    }
}
