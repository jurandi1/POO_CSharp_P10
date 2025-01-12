using System.Globalization;

namespace POO_CSharp_P10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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
            Console.WriteLine("Sintaxe alternativa - expressão condicional ternária");

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
            Console.WriteLine("Sintaxe alternativa - switch-case");
            //exemplo com if else
            Console.WriteLine("exemplo com if else");
            int num = int.Parse(Console.ReadLine());
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