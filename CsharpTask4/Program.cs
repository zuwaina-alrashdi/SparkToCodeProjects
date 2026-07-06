namespace CsharpTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personalized Welcome Function

            //    Console.Write("Enter your name: ");
            //    string userName = Console.ReadLine();

            //    PrintWelcome(userName);
            //}
            //static void PrintWelcome(string name)
            //{
            //    Console.WriteLine("Welcome, " + name + "!");

            /////////////////////////////////////////////////////

            // Task 2 - Square Number Function

            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    int result = Square(number);

            //    Console.WriteLine("Square = " + result);
            //}

            //static int Square(int number)
            //{
            //    return number * number;

            /////////////////////////////////////////////////////

            // Task 3 - Celsius to Fahrenheit Function

            //    Console.Write("Enter the temperature in Celsius: ");
            //    double celsius = double.Parse(Console.ReadLine());

            //    double fahrenheit = CelsiusToFahrenheit(celsius);

            //    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            //}

            //static double CelsiusToFahrenheit(double celsius)
            //{
            //    return (celsius * 9 / 5) + 32;

            /////////////////////////////////////////////////////

            // Task 4 - Fixed Menu Display Function

            //    DisplayMenu();
            //}
            //static void DisplayMenu()
            //{
            //    Console.WriteLine("MENU: ");
            //    Console.WriteLine("1. Start");
            //    Console.WriteLine("2. Help");
            //    Console.WriteLine("3. Exit");

            /////////////////////////////////////////////////////

            // Task 5 - Even or Odd Function

            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    bool result = IsEven(number);

            //    if (result)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //static bool IsEven(int number)
            //{
            //    return number % 2 == 0;

            /////////////////////////////////////////////////////

            // Task 6 - Rectangle Area & Perimeter Functions

            //    Console.Write("Enter the length: ");
            //    double length = double.Parse(Console.ReadLine());

            //    Console.Write("Enter the width: ");
            //    double width = double.Parse(Console.ReadLine());

            //    double area = CalculateArea(length, width);
            //    double perimeter = CalculatePerimeter(length, width);

            //    Console.WriteLine("Area = " + area);
            //    Console.WriteLine("Perimeter = " + perimeter);
            //}

            //static double CalculateArea(double length, double width)
            //{
            //    return length * width;
            //}

            //static double CalculatePerimeter(double length, double width)
            //{
            //    return 2 * (length + width);

            /////////////////////////////////////////////////////

            // Task 7 - Grade Letter Function

            //    Console.Write("Enter your score: ");
            //    int score = int.Parse(Console.ReadLine());

            //    string grade = GetGradeLetter(score);

            //    Console.WriteLine("Grade = " + grade);
            //}
            //static string GetGradeLetter(int score)
            //{
            //    if (score >= 90)
            //    {
            //        return "A";
            //    }
            //    else if (score >= 80)
            //    {
            //        return "B";
            //    }
            //    else if (score >= 70)
            //    {
            //        return "C";
            //    }
            //    else if (score >= 60)
            //    {
            //        return "D";
            //    }
            //    else
            //    {
            //        return "F";
            //    }

            /////////////////////////////////////////////////////

            // Task 8 - Countdown Function

            Console.Write("Enter a starting number: ");
            int number = int.Parse(Console.ReadLine());

            Countdown(number);
        }

        static void Countdown(int number)
        {
            for (int counter = number; counter >= 1; counter--)
            {
                Console.WriteLine(counter);
            }

        }
    }
}
