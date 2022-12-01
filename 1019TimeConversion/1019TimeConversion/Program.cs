namespace TimeConversion {

    public class Program {

        public static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());

            int horas = valor / 3600;
            valor = valor % 3600;

            int minutos = valor / 60;
            valor = valor % 60;

            int segundos = valor;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");         
           
        }
    }
}
