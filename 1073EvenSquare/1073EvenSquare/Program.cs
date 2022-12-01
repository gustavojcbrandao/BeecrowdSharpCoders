namespace EvenSquare {

    public class Program {

        public static void Main(string[] args) {

            int entrada = int.Parse(Console.ReadLine());

            for (int i = 2; i <= entrada; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                }
            }
        }
    }
}