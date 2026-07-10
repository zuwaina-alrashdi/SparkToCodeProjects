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
    }
}
