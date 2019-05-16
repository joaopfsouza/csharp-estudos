using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 05, 15, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            //string s1 = "Good morning dear students!";
            string s1 = "Good";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
