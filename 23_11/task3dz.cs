namespace _23_11
{
    using System;

    public class Task3dz
    {
        public void Execute()
        {
            Console.WriteLine("zagran passport");
            try
            {
                Passport passport = new Passport { PassportNumber = "", FullName = "", Country = "" };
                passport.InputData();
                passport.DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }

    public class Passport
    {
      public required string PassportNumber { get; set; }
        public required string FullName { get; set; }
        public DateTime IssueDate { get; set; }
        public required string Country { get; set; }

        public void InputData()
        {
            Console.Write("vvedit nomer passporta: ");
            PassportNumber = Console.ReadLine()?.Trim() ?? throw new ArgumentException("nomer passporta ne mozhe byti porozhnim.");
            if (string.IsNullOrEmpty(PassportNumber))
                throw new ArgumentException("nomer passporta ne mozhe byti porozhnim.");

            Console.Write("vvedit PIB vlasnika: ");
            FullName = Console.ReadLine()?.Trim() ?? throw new ArgumentException("PIB ne mozhe byti porozhnim.");
            if (string.IsNullOrEmpty(FullName))
                throw new ArgumentException("PIB ne mozhe byti porozhnim.");

            Console.Write("vvedit daty vida4i (yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime issueDate))
                throw new ArgumentException("nevirniy format dati.");
            IssueDate = issueDate;

            Console.Write("vvedit krayiny vida4i: ");
            Country = Console.ReadLine()?.Trim() ?? throw new ArgumentException("krayina vida4i ne mozhe byti porozhnoyu.");
            if (string.IsNullOrEmpty(Country))
                throw new ArgumentException("krayina vida4i ne mozhe byti porozhnoyu.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("infa pro passport:");
            Console.WriteLine($"Nomer passporta: {PassportNumber}");
            Console.WriteLine($"PIB: {FullName}");
            Console.WriteLine($"Data vida4i: {IssueDate:yyyy-MM-dd}");
            Console.WriteLine($"krayina vida4i: {Country}");
        }
    }
}