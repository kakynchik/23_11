namespace _23_11
{
    using System;

    public class Task1Pr
    {
        public void Execute()
        {
            Console.Write("vvedit ryadok sho mistit cifri (0-9): ");
            string input = Console.ReadLine() ?? string.Empty;
            try
            {
                int number = int.Parse(input);
                Console.WriteLine($"Peretvorene 4islo: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("error, nedopystimi simvoli.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("error, 4islo za diapazonom int.");
            }
        }
    }
}