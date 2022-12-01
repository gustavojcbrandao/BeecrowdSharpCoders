namespace SalaryWithBonus {
    public class Program {

        public static void Main(string[] args) {

            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double bonus = vendas * 0.15;
            double salarioFinal = salario + bonus;

            Console.WriteLine($"TOTAL = R$ {salarioFinal:F2}");
        }
    }
}
