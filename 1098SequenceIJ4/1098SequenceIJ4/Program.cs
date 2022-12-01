using System;

namespace SequenceIJ4 {

    public class Program {

        public static void Main(string[] args) {

            int a, b;

            for (double i = 0.0; i < 2; i += 0.2) {
                for (double j = 1.0; j <= 3.0; j++) {
                    if ((i > 0.0 && i < 1.0) || (i > 1.0 && i < 2.0)) {
                        Console.WriteLine($"I={i} J={(i + j)}");
                    }
                    else {
                        a = (int)i;
                        b = (int)i + (int)j;
                        Console.WriteLine($"I={a} J={b}");
                    }
                }
            }
        }
    }
}