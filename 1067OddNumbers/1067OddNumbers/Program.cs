namespace OddNumbers {

    public class Program {

        public static void Main(string[] args) {

            int entrada = int.Parse(Console.ReadLine());

            for(int i = 0; i <= entrada; i++) {
                if(i%2 != 0) {
                    Console.WriteLine(i);
                }
                    
            }

        }
    }
}