namespace AreaOfACircle {

    public class Program {

        public static void Main(string[] args) {

            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine());
            double area;

            area = pi * r * r;

            Console.WriteLine($"A={Math.Round(area, 4)}");

        }

    }

}
