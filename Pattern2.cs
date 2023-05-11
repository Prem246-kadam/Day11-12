using System;

public class Program {
    public static void Main() {
        int rows = 6;
        int columns = 10;

        for (int i = 1; i <= rows; i++) {
            for (int j = 1; j <= columns; j++) {
                if (i == 1 || i == rows || j == 1 || j == columns) {
                    Console.Write("*");
                } else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
