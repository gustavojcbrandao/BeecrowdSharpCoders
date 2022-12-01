namespace HighestAndPosition {

    public class Program {

        public static void Main(string[] args) {

            int maior = 0;
            int posicao = 0;

            for (int i = 0; i < 100; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (i == 0) {
                    maior = valor;
                    posicao = i;
                }
                else {
                    if (valor > maior) {
                        maior = valor;
                        posicao = i;
                    }
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao+1);
        }
    }
}
