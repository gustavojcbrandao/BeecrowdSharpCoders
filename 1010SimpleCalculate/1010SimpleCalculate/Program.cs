namespace SimpleCalculate {
    public class Program {

        public static void Main(string[] args) {

            string[] dados1 = Console.ReadLine().Split();
            string[] dados2 = Console.ReadLine().Split();

            int qtd1 = int.Parse(dados1[1]);
            double valor1 = double.Parse(dados1[2]);
            double total1 = qtd1 * valor1;

            int qtd2 = int.Parse(dados2[1]);
            double valor2 = double.Parse(dados2[2]);
            double total2 = qtd2 * valor2;

            double total = total1 + total2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

        }
    }
}
