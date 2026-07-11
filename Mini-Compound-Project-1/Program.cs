namespace Mini_Compound_Project_1
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Spark Bank: ");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Search Customer");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ListAllAccounts();
                        break;

                    case 7:
                        SearchCustomer();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 8.");
                        break;
                }
            }
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

        // Service 5 - Transfer Amount

        static void TransferAmount()
        {
            Console.Write("Enter sender account number: ");
            string senderAccount = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderAccount);

            if (senderIndex == -1)
            {
                Console.WriteLine("Sender account not found.");
                return;
            }

            Console.Write("Enter receiver account number: ");
            string receiverAccount = Console.ReadLine();

            int receiverIndex = accountNumbers.IndexOf(receiverAccount);

            if (receiverIndex == -1)
            {
                Console.WriteLine("Receiver account not found.");
                return;
            }

            Console.Write("Enter transfer amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Transfer amount must be positive.");
                return;
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine("Transfer successful!");
            Console.WriteLine("Sender New Balance: " + balances[senderIndex]);
        }

        // Service 6 - List All Accounts
        static void ListAllAccounts()
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            Console.WriteLine("All Accounts:");

            for (int i = 1; i < customerNames.Count; i++)
            { 
                Console.WriteLine("Customer Name: " + customerNames[i]);
                Console.WriteLine("Account Number: " + accountNumbers[i]);
                Console.WriteLine("Balance: " + balances[i]);
            }
        }

        // Service 7 - Search Account by Customer Name
        static void SearchCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            int index = customerNames.IndexOf(name);

            if (index == -1)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            Console.WriteLine("Customer Name: " + customerNames[index]);
        }

    }
}