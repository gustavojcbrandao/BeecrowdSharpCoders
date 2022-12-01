namespace Snack {

    public class Program {

        public static void Main(string[] args) {

            string[] opcoes = Console.ReadLine().Split();

            int code = int.Parse(opcoes[0]);
            int quantidade = int.Parse(opcoes[1]);
            double total = 0;

            if (code == 1) {
                total = quantidade * 4.0;
            }
            else if (code == 2) {
                total = quantidade * 4.5;
            }
            else if (code == 3) {
                total = quantidade * 5.0;
            }
            else if (code == 4) {
                total = quantidade * 2.0;
            }
            else if (code == 5) {
                total = quantidade * 1.5;
            }

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}