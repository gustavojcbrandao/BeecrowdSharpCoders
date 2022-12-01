namespace SumOfConsecutiveOddNumbersI {

    public class Program {

        public static void Main(string[] args) {

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            int soma = 0;

            if (numero1 < numero2) {
                for (int i = numero1+1; i < numero2; i++) {
                    if (i % 2 != 0) {
                        soma += i;
                    }
                }
            }
            else {
                for (int i = numero2 +1; i < numero1; i++) {
                    if (i % 2 != 0) {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}