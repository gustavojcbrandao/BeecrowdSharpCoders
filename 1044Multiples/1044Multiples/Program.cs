﻿namespace Multiples {

    public class Program {

        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();

            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            if (valor2 % valor1 == 0 || valor1 % valor2 == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}