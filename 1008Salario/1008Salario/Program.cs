namespace Salario {
    public class Program {

        public static void Main(string[] args) {

            int codigo = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            double salario = horas * valor;

            Console.WriteLine($"NUMBER = {codigo}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}
