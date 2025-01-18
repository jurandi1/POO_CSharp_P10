using System;
using System.Globalization;

namespace POO_CSharp_P10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("DateTimeKind e padrão ISO 8601");
            Console.WriteLine();
            Console.WriteLine("Demo 1");
            DateTime dt1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dt2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dt3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("dt1: " + dt1);
            Console.WriteLine("dt1 Kind: " + dt1.Kind);
            Console.WriteLine("dt1 to Local: " + dt1.ToLocalTime());
            Console.WriteLine("dt1 to Utc: " + dt1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dt2: " + dt2);
            Console.WriteLine("dt2 Kind: " + dt2.Kind);
            Console.WriteLine("dt2 to Local: " + dt2.ToLocalTime());
            Console.WriteLine("dt2 to Utc: " + dt2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dt3: " + dt3);
            Console.WriteLine("dt3 Kind: " + dt3.Kind);
            Console.WriteLine("dt3 to Local: " + dt3.ToLocalTime());
            Console.WriteLine("dt3 to Utc: " + dt3.ToUniversalTime());
            Console.WriteLine("Demo 2");
            DateTime dt4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dt5 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("dt1: " + dt4);
            Console.WriteLine("dt1 Kind: " + dt4.Kind);
            Console.WriteLine("dt1 to Local: " + dt4.ToLocalTime());
            Console.WriteLine("dt1 to Utc: " + dt4.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dt2: " + dt5);
            Console.WriteLine("dt2 Kind: " + dt5.Kind);
            Console.WriteLine("dt2 to Local: " + dt5.ToLocalTime());
            Console.WriteLine("dt2 to Utc: " + dt5.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(dt5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(dt5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Propriedades e Operações com TimeSpan");
            Console.WriteLine();
            Console.WriteLine("Demo: MaxValue, MinValue, Zero");
            TimeSpan time1 = TimeSpan.MaxValue;
            TimeSpan time2 = TimeSpan.MinValue;
            TimeSpan time3 = TimeSpan.Zero;
            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine("Demo - propriedades");
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
            Console.WriteLine("Demo - operações");
            TimeSpan time4 = new TimeSpan(1, 30, 10);
            TimeSpan time5 = new TimeSpan(0, 10, 5);
            TimeSpan sum = time4.Add(time5);
            TimeSpan dif = time4.Subtract(time5);
            TimeSpan mult = time5.Multiply(2.0);
            TimeSpan div = time5.Divide(2.0);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Propriedades e Operações com DateTime");
            Console.WriteLine();
            Console.WriteLine("Demo");
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
            Console.WriteLine();
            Console.WriteLine("Formatação (DateTime -> string)");
            string st1 = d.ToLongDateString();
            string st2 = d.ToLongTimeString();
            string st3 = d.ToShortDateString();
            string st4 = d.ToShortTimeString();
            string st5 = d.ToString();
            string st6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string st7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.WriteLine(st4);
            Console.WriteLine(st5);
            Console.WriteLine(st6);
            Console.WriteLine(st7);
            Console.WriteLine();
            Console.WriteLine("Operações com Datetime");
           /* 
            DateTime x = "";
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
           */
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("TimeSpan");
            Console.WriteLine();
            Console.WriteLine("Representação interna");
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine();
            Console.WriteLine("Demo - Construtores");
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine();
            Console.WriteLine("Demo - métodos From");
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("DateTime");
            Console.WriteLine();

            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2000-08-05");
            DateTime d8 = DateTime.Parse("2000-08-15 13:15:58");

            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("05/08/2000 14:15:58");

            DateTime d11 = DateTime.ParseExact("2000-08-05", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Funções interessantes para string");

            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sintaxe alternativa - expressão condicional ternária");
            Console.Write("Insira um preço para ver o desconto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            if (preco < 20)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);
            //expressão condicional ternária
            Console.WriteLine("expressão condicional ternária");
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sintaxe alternativa - switch-case");
            //exemplo com if else
            Console.Write("Insira um número de 1 á 7: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("exemplo com if else");
            
            string day;
            if (num == 1)
            {
                day = "Sunday";
            }
            else if (num == 2)
            {
                day = "Monday";
            }
            else if (num == 3)
            {
                day = "Tuesday";
            }
            else if (num == 4)
            {
                day = "Wednesday";
            }
            else if (num == 5)
            {
                day = "Thursday";
            }
            else if (num == 6)
            {
                day = "Friday";
            }
            else if (num == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine("Day: " + day);
            Console.WriteLine();
            Console.WriteLine("Exemplo com switch-case");
            switch (num)
            {
                case 1:
                    day = "Sunday";
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
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Inferência de tipos: palavra var");
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}