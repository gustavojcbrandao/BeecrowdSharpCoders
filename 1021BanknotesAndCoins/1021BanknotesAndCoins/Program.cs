namespace BanknotesAndCoins {

    public class Program {

        public static void Main(string[] args) {

            double valor = double.Parse(Console.ReadLine());
            double n;

            Console.WriteLine("NOTAS:");

            n = Math.Floor(valor / 100);
            valor = valor % 100;
            Console.WriteLine($"{n} nota(s) de R$ 100,00");

            n = Math.Floor(valor / 50);
            valor = valor % 50;
            Console.WriteLine($"{n} nota(s) de R$ 50,00");

            n = Math.Floor(valor / 20);
            valor = valor % 20;
            Console.WriteLine($"{n} nota(s) de R$ 20,00");

            n = Math.Floor(valor / 10);
            valor = valor % 10;
            Console.WriteLine($"{n} nota(s) de R$ 10,00");

            n = Math.Floor(valor / 5);
            valor = valor % 5;
            Console.WriteLine($"{n} nota(s) de R$ 5,00");

            n = Math.Floor(valor / 2);
            valor = valor % 2;
            Console.WriteLine($"{n} nota(s) de R$ 2,00");

            Console.WriteLine("MOEDAS:");

            valor = Math.Truncate(valor * 100);

            n = Math.Floor(valor / 100);
            valor = valor % 100;
            Console.WriteLine($"{n} moeda(s) de R$ 1.00");

            n = Math.Floor(valor / 50);
            valor = valor % 50;
            Console.WriteLine($"{n} moeda(s) de R$ 0.50");

            n = Math.Floor(valor / 25);
            valor = valor % 25;
            Console.WriteLine($"{n} moeda(s) de R$ 0.25");

            n = Math.Floor(valor / 10);
            valor = valor % 10;
            Console.WriteLine($"{n} moeda(s) de R$ 0.10");

            n = Math.Floor(valor / 5);
            valor = valor % 5;
            Console.WriteLine($"{n} moeda(s) de R$ 0.05");

            n = Math.Floor(valor / 1);
            valor = valor % 1;
            Console.WriteLine($"{n} moeda(s) de R$ 0.01");

        }
    }
}
