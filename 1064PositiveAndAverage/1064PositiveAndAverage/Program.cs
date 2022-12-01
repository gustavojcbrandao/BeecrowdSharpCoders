namespace PositiveAndAverage {

    public class Program {

        public static void Main(string[] args) {

            int n = 0;
            int count = 0;
            double soma = 0;
            double media = 0;

            while (n < 6) {
                double numero = double.Parse(Console.ReadLine());
                n++;
                if (numero > 0) {
                    count++;
                    soma += numero;
                }
            }
            media = soma / count;
            Console.WriteLine($"{count} valores positivos");
            Console.WriteLine($"{media:F1}");
        }
    }
}
