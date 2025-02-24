namespace _23_11
{
    using System;

    public class CreditCard
    {
        public string CardNumber { get; private set; }
        public string OwnerName { get; private set; }
        public string Cvc { get; private set; }
        public DateTime ExpiryDate { get; private set; }

        public CreditCard(string cardNumber, string ownerName, string cvc, DateTime expiryDate)
        {
            if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
                throw new ArgumentException("Invalid card number. It must be 16 digits.");

            if (string.IsNullOrEmpty(cvc) || cvc.Length != 3 || !int.TryParse(cvc, out _))
                throw new ArgumentException("Invalid CVC. It must be 3 digits.");

            if (string.IsNullOrEmpty(ownerName) || ownerName.Length < 5)
                throw new ArgumentException("Invalid owner name. It must be at least 5 characters.");

            if (expiryDate < DateTime.Now)
                throw new ArgumentException("Card expiry date cannot be in the past.");

            CardNumber = cardNumber;
            OwnerName = ownerName;
            Cvc = cvc;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"Card: {CardNumber}, Owner: {OwnerName}, CVC: {Cvc}, Expiry: {ExpiryDate.ToShortDateString()}";
        }
    }

    public class Task3Pr
    {
        public void Execute()
        {
            try
            {
                CreditCard myCard = new CreditCard("1234567812345678", "John Doe", "123", new DateTime(2026, 12, 31));
                Console.WriteLine(myCard);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}