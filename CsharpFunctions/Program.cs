namespace CsharpFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference

            //Console.Write("Enter the first number: ");
            //double firstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double secondNumber = double.Parse(Console.ReadLine());

            //double difference = firstNumber - secondNumber;
            //double absoluteDifference = Math.Abs(difference);

            //Console.WriteLine("Positive difference: " + absoluteDifference);

            ///////////////////////////////////////////////////////////////////

            // Task 2 - Power & Root Explorer

            //Console.Write("Enter a number: ");
            //double number = double.Parse(Console.ReadLine());

            //double square = Math.Pow(number, 2);
            //double squareRoot = Math.Sqrt(number);

            //Console.WriteLine("Square: " + square);
            //Console.WriteLine("Square Root: " + squareRoot);

            ///////////////////////////////////////////////////////////////////

            // Task 3 - Name Formatter

            //Console.Write("Enter your full name: ");
            //string fullName = Console.ReadLine();

            //string upperName = fullName.ToUpper();
            //string lowerName = fullName.ToLower();
            //int nameLength = fullName.Length;

            //Console.WriteLine("Uppercase: " + upperName);
            //Console.WriteLine("Lowercase: " + lowerName);
            //Console.WriteLine("Number of characters: " + nameLength);

            ///////////////////////////////////////////////////////////////////

            // Task 4 - Subscription End Date

            //Console.Write("Enter the number of free trial days: ");
            //int days = int.Parse(Console.ReadLine());

            //DateTime startDate = DateTime.Today;
            //DateTime endDate = startDate.AddDays(days);

            //Console.WriteLine("Trial end date: " + endDate.ToString("yyyy-MM-dd"));

            ///////////////////////////////////////////////////////////////////

            // Task 5 - Grade Rounding System

            //Console.Write("Enter your exam score: ");
            //double score = double.Parse(Console.ReadLine());

            //double roundedScore = Math.Round(score);

            //Console.WriteLine("Rounded Score: " + roundedScore);

            //if (roundedScore >= 60)
            //{
            //    Console.WriteLine("Result: Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Result: Fail");
            //}

            ///////////////////////////////////////////////////////////////////

            // Task 6 - Password Strength Checker

            //Console.Write("Enter your password: ");
            //string password = Console.ReadLine();

            //if (password.Length >= 8 && !password.ToLower().Contains("password"))
            //{
            //    Console.WriteLine("Strong Password");
            //}
            //else if (password.Length < 8)
            //{
            //    Console.WriteLine("Weak Password: It must be at least 8 characters long.");
            //}
            //else
            //{
            //    Console.WriteLine("Weak Password: It must not contain the word 'password'.");
            //}

            ///////////////////////////////////////////////////////////////////

            // Task 7 - Clean Name Comparator

            //Console.Write("Enter the first name: ");
            //string firstName = Console.ReadLine();

            //Console.Write("Enter the second name: ");
            //string secondName = Console.ReadLine();

            //if (firstName.Trim().ToUpper() == secondName.Trim().ToUpper())
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("No Match");
            //}

            ///////////////////////////////////////////////////////////////////

            // Task 8 - Membership Expiry Checker

            try
            {
                Console.Write("Enter the membership start date (yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter the number of membership days: ");
                int days = int.Parse(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(days);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership Status: Active");
                }
                else
                {
                    Console.WriteLine("Membership Status: Expired");
                }

                Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
