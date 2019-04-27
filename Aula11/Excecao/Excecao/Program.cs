using Excecao.Entities;
using Excecao.Entities.Exception;
using System;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reservation room = new Reservation(8021, new DateTime(2019, 09, 23), new DateTime(2019, 09, 26));
                int roomRent = int.Parse(Console.ReadLine());
                Reservation room = new Reservation(roomRent, new DateTime(2019, 09, 23), new DateTime(2019, 09, 26));

                Console.WriteLine(room);

                Console.WriteLine("Update");
                room.UpdateDays(new DateTime(2019, 09, 24), new DateTime(2019, 09, 29));
                Console.WriteLine(room);

                Console.WriteLine("Update Error");
                room.UpdateDays(new DateTime(2019, 09, 23), new DateTime(2019, 09, 21));
                Console.WriteLine(room);

                Console.WriteLine("Update Error 2");
                room.UpdateDays(new DateTime(2019, 02, 23), new DateTime(2019, 02, 21));
                Console.WriteLine(room);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservetion: {0}", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: {0}", e.Message);
            }


        }

        private static void PadraoTryCatchFinally()
        {
            try
            {
                int a = int.Parse("a");
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException f)
            {
                Console.WriteLine("Format erro!! {0}", f.Message);
            }
            finally
            {
                Console.WriteLine("Fim do Try-Catch");
            }
        }
    }
}
