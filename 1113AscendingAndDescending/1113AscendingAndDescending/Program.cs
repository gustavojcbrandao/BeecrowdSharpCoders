namespace SequenceOfNumbersAndSum {

    public class Program {

        public static void Main(string[] args) {

            while (true) {

                string[] valores = Console.ReadLine().Split();

                int valor1 = int.Parse(valores[0]);
                int valor2 = int.Parse(valores[1]);

                if (valor1 == valor2) {
                    break;
                }
                else {
                    if (valor1 > valor2) {
                        Console.WriteLine("Decrescente");
                    }
                    else {
                        Console.WriteLine("Crescente");
                    }
                }
            }                         
        }
    }
}
