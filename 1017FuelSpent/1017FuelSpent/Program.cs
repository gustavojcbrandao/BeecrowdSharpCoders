namespace FuelSpent {

    public class Program {

        public static void Main(string[] args) {

            double tempo = double.Parse(Console.ReadLine());
            double velocidade = double.Parse(Console.ReadLine());

            double litros = (velocidade * tempo) / 12;

            Console.WriteLine($"{litros:F3}");


        }
    }
}