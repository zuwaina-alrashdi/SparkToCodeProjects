namespace OOP_Part1
{
    internal class Program
    {
        // BankAccount Objects

        static BankAccount account1 = new BankAccount();
        static BankAccount account2 = new BankAccount();

        // Student Objects

        static Student student1 = new Student();
        static Student student2 = new Student();

        // Product Objects

        static Product product1 = new Product();
        static Product product2 = new Product();

        static void Main(string[] args)
        {
            // Bank Account 1

            account1.AccountNumber = 1163;
            account1.HolderName = "karim";
            account1.Balance = 120;

            // Bank Account 2

            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            // Student 1

            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;
            student1.Register("ali@gmail.com");


            // Student 2

            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;
            student2.Register("ahmed@gmail.com");

            // Product 1

            product1.ProductID = 1;
            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.Stock = 50;

            // Product 2

            product2.ProductID = 2;
            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.Stock = 20;

            // Menu will be added here in the next requirement.

        }
    }

}

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

// Product Class
public class Product
{
    // Properties
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    // Method
    public void Restock(int quantity)
    {
        Stock += quantity;
        LogTransaction();
    }

    // Method
    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
        }

        LogTransaction();
    }

    // Method
    public void ViewDetails()
    {
        PrintDetails();
    }

    // Private Method
    private void PrintDetails()
    {
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock: " + Stock);
    }

    // Private Method
    private void LogTransaction()
    {
        // Placeholder for logging product operations
    }
}