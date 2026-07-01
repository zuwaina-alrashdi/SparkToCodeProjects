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

            Console.Write("Enter the Temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

            if (celsius < 10)
            {
                Console.WriteLine("The Weather is Cold");
            }
            else if (celsius >= 10 && celsius <= 30)
            {
                Console.WriteLine("The Weather is Mild");
            }
            else
            {
                Console.WriteLine("The Weather is Hot");
            }

        }
    }
}
