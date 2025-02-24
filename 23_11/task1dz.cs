namespace _23_11
{
    using System;

    public class Task1dz
    {
        public void Execute()
        {
            Console.WriteLine("konvertaciya 4isel");
            Console.WriteLine("napryamok konvertacii:");
            Console.WriteLine("1. 10 -> 2");
            Console.WriteLine("2. 10 -> 8");
            Console.WriteLine("3. 10 -> 16");
            Console.Write("ur choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("nizya, ploha!");
                return;
            }

            Console.Write("vvedit chislo (10 sistema): ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("nevirne vvedenya 4isla!");
                return;
            }

            string result = "";
            try
            {
                switch (choice)
                {
                    case 1:
                        result = Convert.ToString(number, 2);
                        break;
                    case 2:
                        result = Convert.ToString(number, 8);
                        break;
                    case 3:
                        result = Convert.ToString(number, 16).ToUpper();
                        break;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("4islo vihodit za mezhi diapazony.");
                return;
            }

            Console.WriteLine($"resultat konvertacii: {result}");
            Console.WriteLine(new string('-', 40));
        }
    }
}   