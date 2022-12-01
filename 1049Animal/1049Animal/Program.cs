namespace SalaryIncrease {

    public class Program {

        public static void Main(string[] args) {

            string classe1 = Console.ReadLine();
            string classe2 = Console.ReadLine();
            string classe3 = Console.ReadLine();

            if (classe1 == "vertebrado") {
                if (classe2 == "ave") {
                    if (classe3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else if (classe3 == "onivoro") {
                        Console.WriteLine("pomba");
                    }
                }
                else if (classe2 == "mamifero") {
                    if (classe3 == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else if (classe3 == "herbivoro") {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (classe1 == "invertebrado") {
                if (classe2 == "inseto") {
                    if (classe3 == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else if (classe3 == "herbivoro") {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (classe2 == "anelideo") {
                    if (classe3 == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (classe3 == "onivoro") {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}