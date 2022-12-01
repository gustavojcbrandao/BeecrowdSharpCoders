namespace MultiplesOf13 {

    public class Program {

        public static void Main(string[] args) {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int menor = 0;
            int maior = 0;
            int soma = 0;

            if (num1 > num2) {
                menor = num2;
                maior = num1;
            }
            else if (num1 < num2) {
                menor = num1;
                maior = num2;
            }

            for (int i = menor; i <= maior; i++) {

                if (i % 13 != 0) {
                    soma += i;
                }

            }
            Console.WriteLine(soma);

        }
    }
}