namespace Bank_Account_App
{
    public class Bank_Account
    {
        public string Owner { get; set; }
        public decimal Balance { get; private set; }

        public Bank_Account(string owner)
        {
            Owner = owner;
            Balance = 0;
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be greater than zero.";

            Balance += amount;
            return $"Successfully deposited {amount:C}. New balance: {Balance:C}";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "Withdrawal amount must be greater than zero.";

            if (amount > Balance)
                return $"Insufficient funds. Your balance is {Balance:C}.";

            Balance -= amount;
            return $"Successfully withdrew {amount:C}. New balance: {Balance:C}";
        }
    }
}
