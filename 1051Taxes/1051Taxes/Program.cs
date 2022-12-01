namespace DDD {

    public class Program {

        public static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine());

            if (salario <= 2000) {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000){
                double impostos = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {impostos:F2}");
            }
            else if (salario <= 4500) {
                double impostos = (1000 * 0.08) + (salario - 3000) * 0.18;
                Console.WriteLine($"R$ {impostos:F2}");
            }
            else if (salario > 4500) {
                double impostos = (1000 * 0.08) + (1500 * 0.18) + (salario - 4500) * 0.28 ;
                Console.WriteLine($"R$ {impostos:F2}");
            }
        }
    }
}