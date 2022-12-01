namespace GameTime {

    public class Program {
        
        public static void Main(string[] args) {

            string[] horas = Console.ReadLine().Split();

            int inicio = int.Parse(horas[0]);
            int fim = int.Parse(horas[1]);

            if (inicio == fim) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (inicio > fim) {
                int tempo = (24 - inicio) + fim;
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
            }
            else if (fim > inicio) {
                int tempo = fim - inicio;
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
            }
        }   
    }
}