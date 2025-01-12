using System.Globalization;

namespace POO_CSharp_P10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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