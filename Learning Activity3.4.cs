using System;

namespace AgeValidation
{
    class Program
    {
        static void Main()
        {
            LearningActivity34();
        }

        static void LearningActivity34()
        {
            int age;
            bool success = false;

            while (!success)
            {
                Console.Write("Please enter your age (between 10 and 50): ");
                string input = Console.ReadLine();

                // Try to parse the input
                success = int.TryParse(input, out age);

                // Check if the age is valid
                if (!success || age < 10 || age > 50)
                {
                    Console.WriteLine("Invalid age. Please enter a whole number between 10 and 50.");
                    success = false; // Reset success for the next iteration
                }
            }

            Console.WriteLine($"Thank you! Your age is years.");
        }
    }
}
