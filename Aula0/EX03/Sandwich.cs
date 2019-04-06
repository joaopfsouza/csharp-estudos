namespace EX03
{
    public class Sandwich
    {
        public Sandwich(int id, string specification, double value)
        {
            Id=id;
            Specification=specification;
            Value = value;
        }
        public int Id { get; set; }
        public string Specification { get; set; }
        public double Value { get; set; }
    }
}