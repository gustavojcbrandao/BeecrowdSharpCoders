namespace SalaryIncrease {

    public class Program {

        public static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine());

            if (salario <= 400) {
                double novoSalario = salario * 1.15;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                double reajusteGanho = novoSalario - salario;
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario <= 800) {
                double novoSalario = salario * 1.12;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                double reajusteGanho = novoSalario - salario;
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario <= 1200) {
                double novoSalario = salario * 1.10;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                double reajusteGanho = novoSalario - salario;
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario <= 2000) {
                double novoSalario = salario * 1.07;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                double reajusteGanho = novoSalario - salario;
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000) {
                double novoSalario = salario * 1.04;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                double reajusteGanho = novoSalario - salario;
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}