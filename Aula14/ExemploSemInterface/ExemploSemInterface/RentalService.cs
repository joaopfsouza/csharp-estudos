namespace ExemploSemInterface
{
    internal class RentalService
    {
        private double priceHour;
        private double priceDay;

        public RentalService(double priceHour, double priceDay)
        {
            this.priceHour = priceHour;
            this.priceDay = priceDay;
        }
    }
}