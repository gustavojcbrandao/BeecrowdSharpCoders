namespace Comsumption {
    
    public class Program {

        public static void Main(string[] args) {
            
            double distancia = double.Parse(Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());

            double consumo = distancia / volume;

            Console.WriteLine($"{consumo:F3} km/l");

        }
    }
}
