namespace DividingXByY {

    public class Program {

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++) {

                string[] valores = Console.ReadLine().Split();

                double valor1 = double.Parse(valores[0]);
                double valor2 = double.Parse(valores[1]);

                if (valor2 == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    Console.WriteLine($"{(valor1 / valor2):F1}");
                }
            }
        }
    }
}