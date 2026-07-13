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

// Student Class
public class Student
{
    // Properties
    public int Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    // Private Property
    private string email { get; set; }

    // Default Access (private)
    int age { get; set; }

    // Register Method
    public void Register(string Email)
    {
        email = Email;
        SendEmail();
    }

    // Private Method
    private void SendEmail()
    {
        // Placeholder for sending email
    }
}

