namespace EX01.Services
{
    internal interface IPaymentTaxService
    {
        double CalculateAmoutWithTax(double amount, int mounth);
    }
}