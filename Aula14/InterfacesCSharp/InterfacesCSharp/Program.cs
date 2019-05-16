using InterfacesCSharp.Device;
using InterfacesCSharp.Entities;
using InterfacesCSharp.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfacesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("maria".CompareTo("alex"));
            //Console.WriteLine("alex".CompareTo("maria"));
            //Console.WriteLine("maria".CompareTo("maria"));


            //string source = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula14\InterfacesCSharp\names.txt";
            string source = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula14\InterfacesCSharp\employees.txt";

            try
            {
                List<Employee> list = new List<Employee>();

                using (StreamReader sr = File.OpenText(source))
                {

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                }

                list.Sort();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Diamond()
        {
            //IPrinter p = new IPrinter() { SerialNumber = 1080 };
            //p.ProcessDoc("My letter");
            //p.Print("My letter");

            //Scanner s = new Scanner() { SerialNumber = 2003 };
            //p.ProcessDoc("My email");
            //Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 2434 };
            c.ProcessDoc("curriculo");
            c.Print("My letter");
            Console.WriteLine(c.Scan());
        }

        private static void AbstractInterfaceShape()
        {
            AbstractShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            AbstractShape s2 = new Rectangle() { Height = 4.2, Width = 3.5, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine("===================================s");
            Console.WriteLine(s2);
        }
    }
}
