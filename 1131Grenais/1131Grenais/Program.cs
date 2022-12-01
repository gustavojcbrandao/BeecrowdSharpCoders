namespace Grenais {

    public class Program {

        public static void Main(string[] args) {

            Boolean continuar = true;
            int contadorGrenais = 0;
            int inter = 0;
            int gremio = 0;
            int empates = 0;

            while (continuar) {
                string[] resultado = Console.ReadLine().Split();
                int GolInter = int.Parse(resultado[0]);
                int GolGremio = int.Parse(resultado[1]);

                contadorGrenais++;

                if(GolInter > GolGremio) {
                    inter++;
                }
                else if(GolInter < GolGremio) {
                    gremio++;
                }
                else {
                    empates++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int teste = int.Parse(Console.ReadLine());
                if (teste == 1) {
                    continue;
                }
                else if (teste == 2) {
                    continuar = false;
                }
            }
            Console.WriteLine($"{contadorGrenais} grenais");
            Console.WriteLine($"Inter:{inter}");
            Console.WriteLine($"Gremio:{gremio}");
            Console.WriteLine($"Empates:{empates}");
            if (inter > gremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (inter < gremio) {
                Console.WriteLine("Gremio venceu mais");
            }
            else {
                Console.WriteLine("Não houve vencedor");
            }
        }
    }
}