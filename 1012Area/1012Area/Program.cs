namespace Area {
    
    public class Program {

        public static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = (3.14159 * c * c);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");

        }
    }
}