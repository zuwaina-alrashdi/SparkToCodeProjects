using System.Security.Principal;

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

            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register Student");
                Console.WriteLine("7. Compare Account Balances");
                Console.WriteLine("8. Restock Product");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening");
                Console.WriteLine("17. Total Students Counter");
                Console.WriteLine("18. Overdrawn Account Check");
                Console.WriteLine("19. Set Student Security PIN");
                Console.WriteLine("20. Exit");

                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                // Case 1 - View Account Details

                switch (choice)
                {

                    case 1:

                        Console.Write("Choose account (1 or 2): ");
                        int accountChoice = int.Parse(Console.ReadLine());

                        if (accountChoice == 1)
                        {
                            account1.CheckBalance();
                        }
                        else if (accountChoice == 2)
                        {
                            account2.CheckBalance();
                        }
                        else
                        {
                            Console.WriteLine("Invalid account.");
                        }

                        break;

                    // Case 2 - Update Student Address

                    case 2:

                        Console.Write("Choose student (1 or 2): ");
                        int studentChoice = int.Parse(Console.ReadLine());

                        Console.Write("Enter new address: ");
                        string newAddress = Console.ReadLine();

                        if (studentChoice == 1)
                        {
                            student1.Address = newAddress;
                            Console.WriteLine("New Address: " + student1.Address);
                        }
                        else if (studentChoice == 2)
                        {
                            student2.Address = newAddress;
                            Console.WriteLine("New Address: " + student2.Address);
                        }
                        else
                        {
                            Console.WriteLine("Invalid student.");
                        }

                        break;

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
            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * Stock;
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
    }
}
