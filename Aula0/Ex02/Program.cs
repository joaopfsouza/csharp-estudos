using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Insira o Raio");
            double radiusInput = Convert.ToDouble(Console.ReadLine());
            Circle c1 = new Circle(radiusInput);
            System.Console.WriteLine("{0:0.0000}",c1.Area());
        }
    }
}
