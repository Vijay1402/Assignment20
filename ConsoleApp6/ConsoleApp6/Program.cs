using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factorial of {input}: {CalculateFactorial(input)}");
    }

    static int CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}
