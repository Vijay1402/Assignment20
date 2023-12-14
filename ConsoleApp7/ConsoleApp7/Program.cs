using System;

class Program
{
    static void Main()
    {
        int age;

        while (true)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Please enter a valid positive age.");
                }
                else
                {
                    break; // Valid age entered, exit the loop
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer age.");
            }
        }

        if (age < 18)
            Console.WriteLine("You are a minor.");
        else if (age >= 18 && age <= 65)
            Console.WriteLine("You are an adult.");
        else
            Console.WriteLine("You are a senior.");
        Console.ReadKey();
    }
}
