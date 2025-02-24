namespace _23_11
{
    using System;

    public class Task4dz
    {
        public void Execute()
        {
            Console.WriteLine("zavdannya 4: ob4islennya logi4nogo virazy");
            Console.Write("vvedit logi4niy viraz (napryklad, 3>2): ");
            try
            {
                string input = (Console.ReadLine() ?? string.Empty).Trim();
                if (string.IsNullOrEmpty(input))
                    throw new Exception("viraz ne mozhe buty porozhnim.");


                string[] operators = { "<=", ">=", "==", "!=", "<", ">" };
                string opFound = string.Empty;
                foreach (var op in operators)
                {
                    if (input.Contains(op))
                    {
                        opFound = op;
                        break;
                    }
                }

                if (opFound == null)
                    throw new Exception("viraz ne mistit dopustimogo operatora.");

                string[] parts = input.Split(new[] { opFound }, StringSplitOptions.None);
                if (parts.Length != 2)
                    throw new Exception("nekorektniy format virazu.");

                if (!int.TryParse(parts[0].Trim(), out int left))
                    throw new Exception("nevirne 4islo sleva.");
                if (!int.TryParse(parts[1].Trim(), out int right))
                    throw new Exception("nevirne 4islo sprava.");

                bool result = opFound switch
                {
                    "<" => left < right,
                    ">" => left > right,
                    "<=" => left <= right,
                    ">=" => left >= right,
                    "==" => left == right,
                    "!=" => left != right,
                    _ => throw new Exception("nevidomi operator.")
                };

                Console.WriteLine($"result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}