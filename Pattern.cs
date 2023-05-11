using System;

public class Program {
    public static void Main() {
        for (int i = 8; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
