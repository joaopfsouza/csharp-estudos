using EXFIXACAO02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EXFIXACAO02
{
    class Program
    {
        private static NumberStyles cultureinfo;

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberShapes; i++)
            {
                Console.Write("Shape #{0} data:",i);

                Console.Write("Rectangle or Circle (r/c)? ");
                char typeShape = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                string colorShape = Console.ReadLine();

                if (typeShape == 'r')
                {
                    Console.Write("Width: ");
                    double widthShape = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double heightShape = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(widthShape, heightShape, colorShape));

                }
                else if (typeShape == 'c')
                {
                    Console.Write("Radius: ");
                    double radiusShape = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radiusShape, colorShape));

                }

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
