namespace Average3 {

    public class Program {

        public static void Main(string[] args) {

            string[] notas = Console.ReadLine().Split();

            double nota1 = double.Parse(notas[0]); 
            double nota2 = double.Parse(notas[1]); 
            double nota3 = double.Parse(notas[2]); 
            double nota4 = double.Parse(notas[3]);

            double media = Math.Round(((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + nota4)/10, 1, MidpointRounding.ToEven);

            Console.WriteLine($"Media: {media:F1}");

            if(media >= 7) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5) {
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine());
                double mediaFinal = (media + exame) / 2;
                Console.WriteLine($"Nota do exame: {exame:F1}");
                if (mediaFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaFinal:F1}");
                }
            }



        }
    }
}