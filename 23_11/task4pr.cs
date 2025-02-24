namespace _23_11
{
    using System;

    public class Task4Pr
    {
        public void Execute()
        {
            Console.Write("Enter a mathematical expression (only integers and '*' operator): ");
            string input = Console.ReadLine() ?? string.Empty;

            try
            {
                string[] numbers = input.Split('*');
                int result = 1;

                foreach (var number in numbers)
                {
                    if (!int.TryParse(number, out int value))
                        throw new FormatException("Invalid input. Please enter only integers and '*' operator.");

                    result *= value;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Error: {fe.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}