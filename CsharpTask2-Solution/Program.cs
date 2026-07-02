namespace CsharpTask2_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer

            //Console.Write("Enter a starting number: ");
            //int startNumber = int.Parse(Console.ReadLine());

            //for (int counter = startNumber; counter >= 1; counter--)
            //{
            //    Console.WriteLine(counter);
            //}

            //Console.WriteLine("Liftoff!");

            //////////////////////////////////////////////////////////

            // Task 2 - Sum of Numbers 1 to N

            //Console.Write("Enter a positive whole number: ");
            //int positiveNumber = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int counter = 1; counter <= positiveNumber; counter++)
            //{
            //    sum = sum + counter;
            //}

            //Console.WriteLine("The sum is: " + sum);

            //////////////////////////////////////////////////////////

            // Task 3 - Multiplication Table

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int counter = 1; counter <= 10; counter++)
            //{
            //    Console.WriteLine(number + " x " + counter + " = " + (number * counter));
            //}

            //////////////////////////////////////////////////////////

            // Task 4 - Password Retry

            // string correctPassword = "Spark2026";
            // string enteredPassword = "";

            // while (enteredPassword != correctPassword)
            // {
            //     Console.Write("Enter the password: ");
            //     enteredPassword = Console.ReadLine();

            //     if (enteredPassword != correctPassword)
            //     {
            //         Console.WriteLine("Incorrect password, try again");
            //     }

            //     else
            //     {
            //         Console.WriteLine("Access Granted");
            //     }
            //}

            //////////////////////////////////////////////////////////

            // Task 5 - Number Guessing Game

            //    int secretNumber = 42;
            //    int guessNumber;
            //    int attempts = 0;

            //    do
            //    {
            //        Console.Write("Guess the number: ");
            //        guessNumber = int.Parse(Console.ReadLine());

            //        attempts++;

            //        if (guessNumber < secretNumber)
            //        {
            //            Console.WriteLine("Too low");
            //        }
            //        else if (guessNumber > secretNumber)
            //        {
            //            Console.WriteLine("Too high");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Correct!");
            //        }
            //    }
            //    while (guessNumber != secretNumber);

            //    Console.WriteLine("Number of attempts: " + attempts);
            //}

            //////////////////////////////////////////////////////////

            // Task 6 - Safe Division Calculator

            //try
            //{
            //    Console.Write("Enter the first number: ");
            //    int firstNumber = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    int secondNumber = int.Parse(Console.ReadLine());

            //    int result = firstNumber / secondNumber;

            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //}

            //////////////////////////////////////////////////////////

            // Task 7 - Repeating Menu with Exit Option

            //bool exit = false;

            //while (exit == false)
            //{
            //    Console.WriteLine("Menu:");
            //    Console.WriteLine("1. Say Hello");
            //    Console.WriteLine("2. Show Greeting");
            //    Console.WriteLine("3. Exit");

            //    try
            //    {
            //        Console.Write("Choose an option: ");
            //        int choice = int.Parse(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello!");
            //                break;

            //            case 2:
            //                Console.WriteLine("Good Morning!");
            //                break;

            //            case 3:
            //                Console.WriteLine("Goodbye!");
            //                exit = true;
            //                break;

            //            default:
            //                Console.WriteLine("Invalid option.");
            //                break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }

            //    Console.WriteLine();
            //}

            //////////////////////////////////////////////////////////

            // Task 8 - Sum of Even Numbers Only

            Console.Write("Enter a positive whole number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int counter = 1; counter <= number; counter++)
            {
                if (counter % 2 == 0)
                {
                    sum = sum + counter;
                }
            }

            Console.WriteLine("Sum of even numbers: " + sum);

        }
    }
}