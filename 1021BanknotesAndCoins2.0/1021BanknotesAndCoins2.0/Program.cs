namespace BanknotesAndCoins {

    public class Program {

        public static void Main(string[] args) {

            double valor = double.Parse(Console.ReadLine());
            double aux;

            valor = valor * 100;

            Console.WriteLine("NOTAS:");

            aux = Math.Truncate(valor / 10000);
            valor = valor % 10000;
            Console.WriteLine($"{aux} nota(s) de R$ 100.00");

            aux = Math.Truncate(valor / 5000);
            valor = valor % 5000;
            Console.WriteLine($"{aux} nota(s) de R$ 50.00");

            aux = Math.Truncate(valor / 2000);
            valor = valor % 2000;
            Console.WriteLine($"{aux} nota(s) de R$ 20.00");

            aux = Math.Truncate(valor / 1000);
            valor = valor % 1000;
            Console.WriteLine($"{aux} nota(s) de R$ 10.00");

            aux = Math.Truncate(valor / 500);
            valor = valor % 500;
            Console.WriteLine($"{aux} nota(s) de R$ 5.00");

            aux = Math.Truncate(valor / 200);
            valor = valor % 200;
            Console.WriteLine($"{aux} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");

            aux = Math.Truncate(valor / 100);
            valor = valor % 100;
            Console.WriteLine($"{aux} moeda(s) de R$ 1.00");

            aux = Math.Truncate(valor / 50);
            valor = valor % 50;
            Console.WriteLine($"{aux} moeda(s) de R$ 0.50");

            aux = Math.Truncate(valor / 25);
            valor = valor % 25;
            Console.WriteLine($"{aux} moeda(s) de R$ 0.25");

            aux = Math.Truncate(valor / 10);
            valor = valor % 10;
            Console.WriteLine($"{aux} moeda(s) de R$ 0.10");

            aux = Math.Truncate(valor / 5);
            valor = valor % 5;
            Console.WriteLine($"{aux} moeda(s) de R$ 0.05");

            aux = Math.Round(valor);
            Console.WriteLine($"{aux} moeda(s) de R$ 0.01");

        }
    }
}