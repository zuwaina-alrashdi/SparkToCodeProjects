namespace OOP_Part1
{
    // BankAccount Class 
    public class BankAccount
    {
        // Properties
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Deposit Method
        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }

            SendEmail();
        }

        // Check Balance Method
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        // Private Method
        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        // Private Method
        private void SendEmail()
        {
            // Placeholder for sending email
        }
    }
    
    }
