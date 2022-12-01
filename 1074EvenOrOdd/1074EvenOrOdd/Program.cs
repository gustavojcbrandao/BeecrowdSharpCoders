namespace EvenOrOdd {

    public class Program {

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor == 0) {
                    Console.WriteLine("NULL");
                }
                else if (valor % 2 == 0 && valor < 0) {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valor % 2 != 0 && valor < 0) {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (valor % 2 == 0 && valor > 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (valor % 2 == 1 && valor > 0) {
                    Console.WriteLine("ODD POSITIVE");
                }
            }
        }
    }
}