namespace EvenBetweenFiveNumbers {

    public class Program {

        public static void Main(string[] args) {

            int n = 0;
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            while (n < 5) {
                double numero = double.Parse(Console.ReadLine());
                n++;
                if (numero % 2 == 0) {
                    pares++;
                }
                else {
                    impares++;
                }
                if (numero > 0) {
                    positivos++;
                }
                else if (numero < 0) {
                    negativos++;
                }
            }
            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}
