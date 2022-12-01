namespace BhaskarasFormula {

    public class Program {

        public static void Main(string[] args) {

            string[] numeros = Console.ReadLine().Split();

            double a = double.Parse(numeros[0]);
            double b = double.Parse(numeros[1]);
            double c = double.Parse(numeros[2]);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double raizDelta = Math.Sqrt(delta);

            if (a == 0 || delta < 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                double x1 = (-b + raizDelta) / (2 * a);
                double x2 = (-b - raizDelta) / (2 * a);
                Console.WriteLine($"R1 = {x1:F5}");
                Console.WriteLine($"R2 = {x2:F5}");
            }
        }
    }
}
