using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        // Addition
        Console.WriteLine($"Sum: {num1 + num2}");

        // Subtraction
        Console.WriteLine($"Difference: {num1 - num2}");

        // Multiplication
        Console.WriteLine($"Product: {num1 * num2}");

        // Division
        if (num2 != 0)
            Console.WriteLine($"Quotient: {num1 / (double)num2}");
        else
            Console.WriteLine("Cannot divide by zero.");

        // Modulus
        Console.WriteLine($"Remainder: {num1 % num2}");
        Console.ReadKey();
    }
}
