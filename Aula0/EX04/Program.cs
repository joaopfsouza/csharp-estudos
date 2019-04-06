using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Coeficientes:");
            string[] coeficientes = Console.ReadLine().Split(" ");

            double a = Convert.ToDouble(coeficientes[0]);
            double b = Convert.ToDouble(coeficientes[1]);
            double c = Convert.ToDouble(coeficientes[2]);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (!(a.Equals(0) || (delta < 0)))
            {

                double x1 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-1 * b - Math.Sqrt(delta)) / (2 * a);

                System.Console.WriteLine("X1 = {0:0.00000} X2 = {1:0.00000}", x1, x2);


            }
            else
            {

                System.Console.WriteLine("Impossível Calcular");
            }

        }
    }
}
