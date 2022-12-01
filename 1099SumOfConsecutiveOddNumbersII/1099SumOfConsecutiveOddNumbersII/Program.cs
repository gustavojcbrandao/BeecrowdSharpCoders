namespace SumOfConsecutiveOddNumbersII {

    public class Program {

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());

            int maior, menor, soma = 0;

            for(int i = 0; i < quantidade; i++) {

                string[] numeros = Console.ReadLine().Split();
                int num1 = int.Parse(numeros[0]);
                int num2 = int.Parse(numeros[1]);

                if (num1 > num2) {

                    menor = num2;
                    maior = num1;
                }
                else {
                    menor = num1;
                    maior = num2;
                }

                for(int j = menor + 1; j < maior; j++) {

                    if(j % 2 != 0) {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
