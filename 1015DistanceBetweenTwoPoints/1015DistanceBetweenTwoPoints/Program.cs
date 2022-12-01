namespace DistanceBetweenTwoPoints {

    public class Program {

        public static void Main(string[] args) {

            string[] ponto1 = Console.ReadLine().Split();
            string[] ponto2 = Console.ReadLine().Split();

            double x1 = double.Parse(ponto1[0]);
            double y1 = double.Parse(ponto1[1]);

            double x2 = double.Parse(ponto2[0]);
            double y2 = double.Parse(ponto2[1]);

            double distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine($"{distancia:F4}");

        }
    }
}
