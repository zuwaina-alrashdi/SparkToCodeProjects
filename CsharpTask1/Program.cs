using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace CsharpTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personal Info Card

            //string name = "Sara";
            //int age = 21;
            //double height = 1.65;
            //bool isStudent = true;

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Height: " + height);
            //Console.WriteLine("Student: " + isStudent);

            ////////////////////////////////////////////////////

            // Task 2 - Rectangle Calculator

            //Console.Write("Please Enter the Rectangle Length: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Please Enter the Rectangle Width: ");
            //double width = double.Parse(Console.ReadLine());

            //double area = length * width;
            //double perimeter = 2 * (length + width);

            //Console.WriteLine("Area: " + area);
            //Console.WriteLine("perimeter: " + perimeter);

            ////////////////////////////////////////////////////

            // Task 3 - Even or Odd Checker

            //Console.WriteLine("Enter a Whole Number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0 )
            //{
            //    Console.WriteLine("The Number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("The Number is Odd");
            //}

            ////////////////////////////////////////////////////

            // Task 4 - Voting Eligibility

            //Console.Write("Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Do you hold a valid national ID (yes/no)?: ");
            //string answer = Console.ReadLine();

            //bool ValidID = answer == "yes";

            //if (age >= 18 && ValidID)
            //{
            //    Console.WriteLine("You are Eligible to Vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not Eligible to Vote.");
            //}

            ////////////////////////////////////////////////////

            // Task 5 - Grade Letter Lookup

            //Console.Write("Enter your grade (A, B, C, D, F): ");
            //char degree = char.Parse(Console.ReadLine());

            //switch (degree)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;


            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;


            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;


            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;


            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}

            ////////////////////////////////////////////////////

            // Task 6 - Temperature Converter

            //Console.Write("Enter the Temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

            //if (celsius < 10)
            //{
            //    Console.WriteLine("The Weather is Cold");
            //}
            //else if (celsius >= 10 && celsius <= 30)
            //{
            //    Console.WriteLine("The Weather is Mild");
            //}
            //else
            //{
            //    Console.WriteLine("The Weather is Hot");
            //}

            ////////////////////////////////////////////////////

            // Task 7 - Movie Ticket Pricing

            //Console.WriteLine("Enter your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 12)
            //{
            //    Console.WriteLine("Category: Children");
            //    Console.WriteLine("Price: 2.000 OMR");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    Console.WriteLine("Category: Adults");
            //    Console.WriteLine("Price: 5.000 OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Category: Seniors");
            //    Console.WriteLine("Price: 3.000 OMR");
            //}

            ////////////////////////////////////////////////////

            // Task 8 -  Restaurant Bill with Membership Discount

            //Console.Write("Enter Your Total Bill Amount: ");
            //float bill = float.Parse(Console.ReadLine());

            //Console.Write("Are you a Loyalty Member (yes/no)?: ");
            //string answer = Console.ReadLine();

            //bool LoyaltyMember = answer == "yes";

            //if ( bill > 20 && LoyaltyMember)
            //{
            //    float discount = bill * 0.15f;
            //    float finalBill = bill - discount; 

            //    Console.WriteLine("Original Bill: " + bill + " OMR " );
            //    Console.WriteLine("Discount: " + discount + " OMR ");
            //    Console.WriteLine("Final Amount: " + finalBill + " OMR ");
            //}
            //else
            //{
            //    Console.WriteLine("Original Bill: " + bill + " OMR ");
            //    Console.WriteLine("Discount: 0 OMR");
            //    Console.WriteLine("Final Amount: " + bill + " OMR ");
            //}

            ////////////////////////////////////////////////////

            // Task 9 - Day Name Finder

            //Console.Write("Enter a Number From 1 to 7: ");
            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;


            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;


            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;


            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;


            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;

            ////////////////////////////////////////////////////

            // Task 10 - Mini Calculator

            //Console.Write("Enter the First Number: ");
            //double firstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter the Second Number: ");
            //double secondNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter an Operator (+, -, *, /, %): ");
            //char operation = char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine("Result: " + (firstNumber + secondNumber));
            //        break;


            //    case '-':
            //        Console.WriteLine("Result: " + (firstNumber - secondNumber));
            //        break;


            //    case '*':
            //        Console.WriteLine("Result: " + (firstNumber * secondNumber));
            //        break;


            //    case '/':
            //        if (secondNumber != 0)
            //        {
            //            Console.WriteLine("Result: " + (firstNumber / secondNumber));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //        }
            //        break;

            //    case '%':
            //        if (secondNumber != 0)
            //        {
            //            Console.WriteLine("Result: " + (firstNumber % secondNumber));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}

            ////////////////////////////////////////////////////

            // Task 11 - Loan Eligibility System

            Console.Write("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Monthly Income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Do You Have an Existing Loan (yes/no)?: ");
            string answer = Console.ReadLine();

            bool loan = answer == "yes";

            if (age >= 21 && age <= 60 && income >= 400 && !loan)
            {
                Console.WriteLine("You are eligible for the loan.");
            }
            else if (age < 21 || age > 60)
            {
                Console.WriteLine("Not eligible, Age is out of range.");
            }
            else if (income < 400)
            {
                Console.WriteLine("Not eligible, Income is too low.");
            }
            else
            {
                Console.WriteLine("Not eligible, You have an existing loan.");
            }


        }
    }


        }
