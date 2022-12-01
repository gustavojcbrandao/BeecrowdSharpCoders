namespace Experiments {

    public class Program {

        public static void Main(string[] args) {

            int j = 60;

            for (int i = 1; i < 38; i = i + 3) {
                Console.WriteLine($"I={i} J={j}");
                j -= 5;              
            }
        }
    }
}
