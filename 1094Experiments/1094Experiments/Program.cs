namespace Experiments {

    public class Program {

        public static void Main(string[] args) {

            int cobaias = 0;
            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            double pCoelhos = 0;
            double pRatos = 0;
            double pSapos = 0;

            int testes = int.Parse(Console.ReadLine());
            

            for(int i = 0; i < testes; i++) {

                string[] experimento = Console.ReadLine().Split();

                int quantidade = int.Parse(experimento[0]);
                string animal = experimento[1];

                cobaias+= quantidade;

                if (animal == "C") {
                    coelhos+= quantidade;
                }
                if (animal == "R") {
                    ratos += quantidade;
                }
                if (animal == "S") {
                    sapos += quantidade;
                }
            }
            Console.WriteLine($"Total: {cobaias} cobaias");

            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");

            pCoelhos = (double)coelhos/(double)cobaias*100;
            Console.WriteLine($"Percentual de coelhos: {pCoelhos:F2} %");

            pRatos = (double)ratos / (double)cobaias *100;
            Console.WriteLine($"Percentual de ratos: {pRatos:F2} %");

            pSapos = (double)sapos / (double)cobaias *100;
            Console.WriteLine($"Percentual de sapos: {pSapos:F2} %");
        }
    }
}
