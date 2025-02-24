namespace _23_11
{
    using System;
    public class Task2dz
    {
        private readonly Dictionary<string, int> _digitWords =
            new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "zero", 0 },
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 }
            };

        public void Execute()
        {
            Console.WriteLine("peretvorenya slov na 4isla");
            Console.Write("vvedit slovo sho pozna4aye cifry (0-9): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (_digitWords.TryGetValue(input, out int digit))
            {
                Console.WriteLine($"cifra: {digit}");
            }
            else
            {
                Console.WriteLine("nevirne vvedennia!");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}