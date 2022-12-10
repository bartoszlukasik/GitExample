using System;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Average Calculator!");
            Console.WriteLine("Please enter the scores of your students one by one, and enter -1 to get the average:");

            double sum = 0;
            int count = 0;

            // Read the scores until -1 is entered
            while (true)
            {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();

                // Check if the input is -1 and exit the loop if it is
                if (input == "-1")
                {
                    break;
                }

                // Try to parse the input as a number
                if (double.TryParse(input, out double score))
                {
                    // Check if the score is in the correct range
                    if (score >= 0 && score <= 20)
                    {
                        sum += score;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Error: Score must be between 0 and 20. Ignoring input.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Must be a number between 0 and 20. Ignoring input.");
                }
            }

            // Calculate the average and print it to the console
            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"The average score is: {average:F2}");
            }
            else
            {
                Console.WriteLine("No valid scores were entered.");
            }
        }
    }
}