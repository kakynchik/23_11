namespace _23_11
{
    using System;

    public class Task2Pr
    {
        public void Execute()
        {
            Console.Write("vvedit 2-koviy ryadok (lishe 1 i 0): ");
            string input = Console.ReadLine() ?? string.Empty;
            try
            {
                foreach (char c in input)
                {
                    if (c != '0' && c != '1')
                        throw new FormatException("ryadok povinen mistiti lishe 0 i 1.");
                }
                int number = Convert.ToInt32(input, 2);
                Console.WriteLine($"peretvorene desyatkove 4islo: {number}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"pomilka formyvannya: {fe.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("error, 4islo vishlo za mezhi diapazony int.");
            }
        }
    }
}