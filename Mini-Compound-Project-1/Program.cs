namespace Mini_Compound_Project_1
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            AddAccount();
            DepositMoney();
            WithdrawMoney();
            ShowBalance();
        }

        // Service 1 - Add New Account
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("This account number already exists.");
                return;
            }

            Console.Write("Enter initial deposit: ");
            double balance = double.Parse(Console.ReadLine());

            if (balance < 0)
            {
                Console.WriteLine("Initial deposit cannot be negative.");
                return;
            }

            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(balance);

            Console.WriteLine("Account created successfully!");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);

        }

        // Service 2 - Deposit Money

        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balances[index] += amount;

            Console.WriteLine("Deposit successful.");
            Console.WriteLine("Updated Balance: " + balances[index]);

        }


        // Service 3 - Withdraw Money
        static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount >= balances[index])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[index] -= amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Updated Balance: " + balances[index]);
        }


        // Service 4 - Show Balance
        static void ShowBalance()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Current Balance: " + balances[index]);
        }

    }
}