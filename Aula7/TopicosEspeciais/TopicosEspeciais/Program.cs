using System;
using System.Globalization;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }

        private static void KindDateTime()
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("===================");

            Console.WriteLine("d1: {0}", d1);
            Console.WriteLine("d1 Kind: {0}", d1.Kind);
            Console.WriteLine("d1 to Local: {0}", d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: {0}", d1.ToUniversalTime());

            Console.WriteLine("===================");

            Console.WriteLine("d2: {0}", d2);
            Console.WriteLine("d2 Kind: {0}", d2.Kind);
            Console.WriteLine("d2 to Local: {0}", d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: {0}", d2.ToUniversalTime());

            Console.WriteLine("===================");

            Console.WriteLine("d3: {0}", d3);
            Console.WriteLine("d3 Kind: {0}", d3.Kind);
            Console.WriteLine("d3 to Local: {0}", d3.ToLocalTime());
            Console.WriteLine("d3 to UTC: {0}", d3.ToUniversalTime());
        }

        private static void TimeStampOperacoes()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);


            t1 = new TimeSpan(1, 30, 10);
            t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }

        private static void OperacoesDateTime()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(d);


            Console.WriteLine(d.AddHours(2));
            Console.WriteLine(d.AddMinutes(3));

            d = DateTime.Now;
            Console.WriteLine(d.AddDays(7));

            d = DateTime.Now;
            Console.WriteLine(d.AddDays(7));

            DateTime d1 = new DateTime(2000, 10, 15);
            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan r = d2.Subtract(d1);

            Console.WriteLine("Sub {0}", r.TotalDays);
        }

        private static void StringDataTime()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss:fff"));
        }

        private static void PropriedadesDataTime()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
        }

        private static void TimeStampInstance()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);
            Console.WriteLine(t2.Ticks);

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);
            Console.WriteLine(t3.Ticks);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);
            Console.WriteLine(t4.Ticks);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);
            Console.WriteLine(t5.Ticks);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromMilliseconds(1.0);
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromTicks(89968966l);
            Console.WriteLine(t11);

            TimeSpan s = t9 + t10;
            Console.WriteLine(s);
        }

        private static void DateTimeFormat()
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            d1 = new DateTime(2019, 04, 05);
            Console.WriteLine(d1);

            d1 = new DateTime(2019, 04, 05, 17, 14, 20);
            Console.WriteLine(d1);

            d1 = new DateTime(2019, 04, 05, 17, 14, 20, 500);
            Console.WriteLine(d1);

            d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = DateTime.Today;
            Console.WriteLine(d1);

            d1 = DateTime.UtcNow;
            Console.WriteLine(d1);

            d1 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d1);

            d1 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d1);

            d1 = DateTime.Parse("15/03/2018");
            Console.WriteLine(d1);

            d1 = DateTime.Parse("18:58:01");
            Console.WriteLine(d1);

            d1 = DateTime.ParseExact("2010-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);

            d1 = DateTime.ParseExact("15/08/2011 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
        }

        private static void StringMethod()
        {
            string original = "abcde FGHIJ ABC abc DEFG      ";

            string s = original.ToUpper();

            Console.WriteLine("Original: -{0}-", original);

            Console.WriteLine("ToUpper: -{0}-", s);

            s = original.ToLower();
            Console.WriteLine("ToLower: -{0}-", s);

            s = original.ToLower();
            Console.WriteLine("ToLower: -{0}-", s);

            s = original.Trim();
            Console.WriteLine("Trim: -{0}-", s);

            int n1 = original.IndexOf("bc");
            Console.WriteLine("IndexOf('bc'): {0}", n1);

            n1 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf('bc'): {0}", n1);

            s = original.Substring(3);
            Console.WriteLine("Substring(3): -{0}-", s);

            s = original.Substring(3, 5);
            Console.WriteLine("Substring(3,5): -{0}-", s);

            s = original.Replace('a', 'x');
            Console.WriteLine("Replace('a','x'): -{0}-", s);

            s = original.Replace("abc", "xyx");
            Console.WriteLine("Replace('abc','xyx'): -{0}-", s);

            bool b = String.IsNullOrEmpty(original);
            Console.WriteLine("IsNullOrEmpty: {0}", b);

            b = String.IsNullOrWhiteSpace("                  ");
            Console.WriteLine("IsNullOrWhiteSpace: {0}", b);
        }

        private static void Ternario()
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.10 : preco * 0.05;

            Console.WriteLine(desconto);
        }

        private static void SwitchTest()
        {
            Console.WriteLine("Digite o dia: ");
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sanday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid Value";
                    break;
            }

            Console.WriteLine("Day: " + day);
        }

        private static void TestVar()
        {
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
