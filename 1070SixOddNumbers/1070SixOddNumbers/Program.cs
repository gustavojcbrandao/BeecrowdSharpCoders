namespace SixOddNumbers {

    public class Program {

        public static void Main(string[] args) {

            int numero = int.Parse(Console.ReadLine());

                for (int i = numero; i < numero + 12; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                        i++;
                    }
                }
        }
    }
}