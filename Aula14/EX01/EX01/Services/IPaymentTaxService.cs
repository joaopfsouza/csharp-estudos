namespace EX01.Services
{
    internal interface IPaymentTaxService
    {
        double Interest(double amount, int mounths);
        double PaymentFee(double amount);
       
    }
}