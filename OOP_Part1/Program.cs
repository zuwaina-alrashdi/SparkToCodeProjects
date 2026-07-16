using System.Collections;
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

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                // Case 1 - View Account Details

                switch (choice)
                {

                    case 1:
                        {
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
                        }

                    // Case 2 - Update Student Address

                    case 2:
                        {
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

                    // Case 3 - Make a Deposit

                    case 3:
                        {
                            Console.Write("Choose account (1 or 2): ");
                            int accountChoice = int.Parse(Console.ReadLine());

                            Console.Write("Enter deposit amount: ");
                            double deposit = double.Parse(Console.ReadLine());

                            if (accountChoice == 1)
                            {
                                account1.Deposit(deposit);
                                Console.WriteLine(account1.HolderName);
                                Console.WriteLine(account1.Balance);
                            }
                            else if (accountChoice == 2)
                            {
                                account2.Deposit(deposit);
                                Console.WriteLine(account2.HolderName);
                                Console.WriteLine(account2.Balance);
                            }
                            else
                            {
                                Console.WriteLine("Invalid account.");
                            }

                            break;
                        }

                    // Case 4 - Make a Withdrawal

                    case 4:
                        {
                            Console.Write("Choose account (1 or 2): ");
                            int accountChoice = int.Parse(Console.ReadLine());

                            Console.Write("Enter withdrawal amount: ");
                            double withdraw = double.Parse(Console.ReadLine());

                            if (accountChoice == 1)
                            {
                                account1.Withdraw(withdraw);
                                Console.WriteLine("Updated Balance: " + account1.Balance);
                            }
                            else if (accountChoice == 2)
                            {
                                account2.Withdraw(withdraw);
                                Console.WriteLine("Updated Balance: " + account2.Balance);
                            }
                            else
                            {
                                Console.WriteLine("Invalid account.");
                            }

                            break;
                        }

                    // Case 5 - View Product Details

                    case 5:
                        {
                            Console.Write("Choose product (1 or 2): ");
                            int productChoice = int.Parse(Console.ReadLine());

                            if (productChoice == 1)
                            {
                                double total = product1.GetInventoryValue();
                                Console.WriteLine("Inventory Value: " + total);
                            }
                            else if (productChoice == 2)
                            {
                                double total = product2.GetInventoryValue();
                                Console.WriteLine("Inventory Value: " + total);
                            }
                            else
                            {
                                Console.WriteLine("Invalid product.");
                            }

                            break;
                        }

                    // Case 6 - Register a Student

                    case 6:
                        {
                            Console.Write("Choose student (1 or 2): ");
                            int studentNumber = int.Parse(Console.ReadLine());

                            Console.Write("Enter email: ");
                            string email = Console.ReadLine();

                            if (studentNumber == 1)
                            {
                                student1.Register(email);
                                Console.WriteLine("Student registered successfully.");
                            }
                            else if (studentNumber == 2)
                            {
                                student2.Register(email);
                                Console.WriteLine("Student registered successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid student.");
                            }

                            break;
                        }

                    // Case 7 - Compare Two Account Balances

                    case 7:
                        {
                            if (account1.Balance > account2.Balance)
                            {
                                Console.WriteLine(account1.HolderName + " has the higher balance.");
                            }
                            else if (account2.Balance > account1.Balance)
                            {
                                Console.WriteLine(account2.HolderName + " has the higher balance.");
                            }
                            else
                            {
                                Console.WriteLine("Both accounts have the same balance.");
                            }

                            break;
                        }
                       
                    // Case 8 - Restock Product & Stock Level Check

                    case 8:
                        {
                            Console.Write("Choose product (1 or 2): ");
                            int productChoice = int.Parse(Console.ReadLine());

                            Console.Write("Enter quantity to add: ");
                            int quantity = int.Parse(Console.ReadLine());

                            if (productChoice == 1)
                            {
                                product1.Restock(quantity);

                                if (product1.Stock < 10)
                                {
                                    Console.WriteLine("Stock Level: Low");
                                }
                                else if (product1.Stock < 50)
                                {
                                    Console.WriteLine("Stock Level: Moderate");
                                }
                                else
                                {
                                    Console.WriteLine("Stock Level: Well Stocked");
                                }
                            }
                            else if (productChoice == 2)
                            {
                                product2.Restock(quantity);

                                if (product2.Stock < 10)
                                {
                                    Console.WriteLine("Stock Level: Low");
                                }
                                else if (product2.Stock < 50)
                                {
                                    Console.WriteLine("Stock Level: Moderate");
                                }
                                else
                                {
                                    Console.WriteLine("Stock Level: Well Stocked");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid product.");
                            }

                            break;
                        }

                    // Case 16 - Quick Account Opening [Parameterized Constructor]

                    case 16:
                        {
                            Console.Write("Enter account number: ");
                            int accountNumber = int.Parse(Console.ReadLine());

                            Console.Write("Enter holder name: ");
                            string holderName = Console.ReadLine();

                            Console.Write("Enter starting balance: ");
                            double balance = double.Parse(Console.ReadLine());

                            if (balance < 0)
                            {
                                Console.WriteLine("Balance cannot be negative.");
                                break;
                            }

                            BankAccount newAccount = new BankAccount(accountNumber, holderName, balance);

                            Console.WriteLine("Account created successfully!");
                            Console.WriteLine("Account Number: " + newAccount.AccountNumber);
                            Console.WriteLine("Holder Name: " + newAccount.HolderName);
                            Console.WriteLine("Balance: " + newAccount.Balance);

                            break;
                        }

                    // Case 17 - Total Students Counter [Static Fields & Methods]

                    case 17:
                        {
                            Console.WriteLine("Total Students: " + Student.GetStudentCount());
                            break;
                        }

                    // Case 18 - Overdrawn Account Check [Read-Only Property]

                    case 18:
                        {
                            Console.Write("Choose account (1 or 2): ");
                            int accountChoice = int.Parse(Console.ReadLine());

                            if (accountChoice == 1)
                            {
                                if (account1.IsOverdrawn)
                                {
                                    Console.WriteLine("Account is overdrawn.");
                                }
                                else
                                {
                                    Console.WriteLine("Account is not overdrawn.");
                                }
                            }
                            else if (accountChoice == 2)
                            {
                                if (account2.IsOverdrawn)
                                {
                                    Console.WriteLine("Account is overdrawn.");
                                }
                                else
                                {
                                    Console.WriteLine("Account is not overdrawn.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid account.");
                            }

                            break;
                        }


                    // Case 19 - Set Student Security PIN [Write-Only Property]

                    case 19:
                        {
                            Console.Write("Choose student (1 or 2): ");
                            int studentChoice = int.Parse(Console.ReadLine());

                            Console.Write("Enter a 4-digit PIN: ");
                            string pin = Console.ReadLine();

                            if (studentChoice == 1)
                            {
                                student1.SecurityPIN = pin;

                                if (student1.PinSet)
                                {
                                    Console.WriteLine("Security PIN has been set successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("PIN must be exactly 4 digits.");
                                }
                            }
                            else if (studentChoice == 2)
                            {
                                student2.SecurityPIN = pin;

                                if (student2.PinSet)
                                {
                                    Console.WriteLine("Security PIN has been set successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("PIN must be exactly 4 digits.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid student.");
                            }

                            break;
                        }


                    // Case 20 - Exit

                    case 20:
                        {
                            exitApp = true;
                            Console.WriteLine("Thank you for using the Banking System. Goodbye!");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid option. Please choose a number between 1 and 20.");
                            break;
                        }
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

            public bool IsOverdrawn
            {
                get
                {
                    return Balance < 0;
                }
            }

            // Default Constructor
            public BankAccount()
            {

            }

            // Parameterized Constructor
            public BankAccount(int accountNumber, string holderName, double balance)
            {
                AccountNumber = accountNumber;
                HolderName = holderName;
                Balance = balance;
            }

            // Deposit Method

            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid deposit amount.");
                    return;
                }

                Balance += amount;
                SendEmail();
            }

            // Withdraw Method
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                    return;
                }

                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }

                SendEmail();
            }

            // Check Balance Method
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
            int age { get; set; }

            private string pin;

            public bool PinSet { get; private set; }

            public string SecurityPIN
            {
                set
                {
                    if (value.Length == 4 && int.TryParse(value, out _))
                    {
                        pin = value;
                        PinSet = true;
                    }
                    else
                    {
                        PinSet = false;
                    }
                }
            }

            private static int StudentCount = 0;

            public Student()
            {
                StudentCount++;
            }

            public static int GetStudentCount()
            {
                return StudentCount;
            }

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
                if (quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity.");
                    return;
                }

                Stock += quantity;
                LogTransaction();
            }

            // Method
            public void Sell(int quantity)
            {
                if (quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity.");
                    return;
                }

                if (Stock >= quantity)
                {
                    Stock -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock.");
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
