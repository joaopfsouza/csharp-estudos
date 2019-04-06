namespace Ex02
{
    public class Circle
    {
        private const double PI = System.Math.PI;

        public Circle() { }

        public Circle(double radius) => Radius = radius;

        public double Radius { get; set; }

        public double Area() => PI * System.Math.Pow(Radius, 2);
    }
}