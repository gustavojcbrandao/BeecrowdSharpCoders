namespace Triangle {

    public class Program {

        public static void Main(string[] args) {

            string[] lados = Console.ReadLine().Split();

            double a = double.Parse(lados[0]);
            double b = double.Parse(lados[1]);
            double c = double.Parse(lados[2]);

            if (Math.Abs(b - c) < a && a < (b + c) && (Math.Abs(a - c) < b && b < (a + c)) && (Math.Abs(a - b) < c && c < (a + b))) {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro:F1}");

            }
            else {
                double area = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {area:F1}");
            }

            
        }
    }
}