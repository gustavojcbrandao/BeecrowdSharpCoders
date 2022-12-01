namespace EvenBetweenFiveNumbers {

    public class Program {

        public static void Main(string[] args) {

            int n = 0;
            int count = 0;

            while (n < 5) {
                double numero = double.Parse(Console.ReadLine());
                n++;
                if (numero % 2 == 0) {
                    count++;
                }
            }
            Console.WriteLine($"{count} valores pares");
        }
    }
}
