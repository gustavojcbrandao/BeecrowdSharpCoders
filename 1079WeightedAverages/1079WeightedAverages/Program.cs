namespace WeightedAverages {

    public class Program {

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++) {
                string[] notas = Console.ReadLine().Split();
                double nota1 = double.Parse(notas[0]);
                double nota2 = double.Parse(notas[1]);
                double nota3 = double.Parse(notas[2]);

                double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/10;
                Console.WriteLine($"{media:F1}");
            }
        }
    }
}