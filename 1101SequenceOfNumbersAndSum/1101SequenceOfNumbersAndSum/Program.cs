namespace SequenceOfNumbersAndSum {

    public class Program {

        public static void Main(string[] args) {

            int a = 1;
            int b = 1;
            int menor, maior;
            int soma = 0;

            while (true) {

                string[] numeros = Console.ReadLine().Split();
                int num1 = int.Parse(numeros[0]);
                int num2 = int.Parse(numeros[1]);

                if (num1 <= 0 || num2 <= 0) {
                    break;
                }

                if (num1 > num2) {

                    menor = num2;
                    maior = num1;
                }
                else {
                    menor = num1;
                    maior = num2;
                }
                for (int i = menor; i <= maior; i++) {
                    Console.Write($"{i} ");
                    soma += i;                      
                }
                Console.WriteLine($"Sum={soma}");
                soma = 0;             
            }
        }
    }
}
