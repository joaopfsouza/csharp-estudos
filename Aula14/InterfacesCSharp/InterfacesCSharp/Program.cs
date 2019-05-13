using InterfacesCSharp.Entities;
using InterfacesCSharp.Model.Entities;
using System;

namespace InterfacesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            AbstractShape s2 = new Rectangle() { Height = 4.2, Width = 3.5, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine("===================================s");
            Console.WriteLine(s2);
        }
    }
}

