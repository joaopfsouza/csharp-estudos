namespace Aula0.Model
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(int id, int unit, double price)
        {
            Id=id;
            Unit=unit;
            Price = price;
        }
        public int Id { get; set; }
        public int Unit { get; set; }
        public double Price { get; set; }

        public double Amount(){
            return Unit * Price;
        }

    }
}