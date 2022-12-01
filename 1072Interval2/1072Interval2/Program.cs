namespace Interval2 {

    public class Program {

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < quantidade; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}