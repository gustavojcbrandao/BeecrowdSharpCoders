namespace AgeInDays {

    public class Program {

        public static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());

            int anos = valor / 365;
            valor = valor % 365;
            Console.WriteLine($"{anos} ano(s)");

            int meses = valor / 30;
            valor = valor % 30;
            Console.WriteLine($"{meses} mes(es)");

            int dias = valor;
            Console.WriteLine($"{dias} dia(s)");

            Console.WriteLine($"");

        }
    }
}
