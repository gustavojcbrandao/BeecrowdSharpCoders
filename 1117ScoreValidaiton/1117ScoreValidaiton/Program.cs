namespace ScoreValidation {

    public class Program {

        public static void Main(string[] args) {

            double soma = 0;
            int k = 0;

            while (true) {

                double nota = double.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10) {
                    soma += nota;
                    k++;
                }
                else {
                    Console.WriteLine("nota invalida");
                }
                if (k == 2) {
                    Console.WriteLine($"media = {(soma / 2):F2}");
                    break;
                }
            }
        }
    }
}