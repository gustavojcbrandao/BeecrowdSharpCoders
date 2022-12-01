namespace PrimeNumber {

    public class Program {

        static public bool isPrime(int value) {

            if (value == 1) return false;
            for(int i = 2; i < value; i++) {
                if (value % i == 0) return false;
            }
            return true;
        } 

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++) {

                int numero = int.Parse(Console.ReadLine());

                string resp = $"{numero}";

                if (!isPrime(numero)) resp += "nao ";

                
                
            else  resp += "eh primo";
        }

        }
    }

