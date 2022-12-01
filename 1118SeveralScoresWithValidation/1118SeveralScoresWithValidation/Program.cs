namespace SeveralScoresWithValidation {

    public class Program {

        public static void Main(string[] args) {

            double soma = 0;
            int k = 0;
            Boolean continuar = true;

            while (true) {
                continuar = true;
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
                    while (continuar) {

                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        int teste = int.Parse(Console.ReadLine());
                        if (teste == 1) {
                            soma = 0;
                            k = 0;
                            continuar = false;
                        }
                        if (teste == 2) {
                            return;
                        }
                    }
                }
            }
        }
    }
}