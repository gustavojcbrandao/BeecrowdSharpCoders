namespace Banknotes {

    public class Program {

        public static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());
            int n;

            Console.WriteLine(valor);
            n = valor / 100;
            valor = valor % 100;
            Console.WriteLine($"{n} nota(s) de R$ 100,00");
            n = valor / 50;
            valor = valor % 50;
            Console.WriteLine($"{n} nota(s) de R$ 50,00");
            n = valor / 20;
            valor = valor % 20;
            Console.WriteLine($"{n} nota(s) de R$ 20,00");
            n = valor / 10;
            valor = valor % 10;
            Console.WriteLine($"{n} nota(s) de R$ 10,00");
            n = valor / 5;
            valor = valor % 5;
            Console.WriteLine($"{n} nota(s) de R$ 5,00");
            n = valor / 2;
            valor = valor % 2;
            Console.WriteLine($"{n} nota(s) de R$ 2,00");
            n = valor / 1;
            Console.WriteLine($"{n} nota(s) de R$ 1,00");
        }
    }
}