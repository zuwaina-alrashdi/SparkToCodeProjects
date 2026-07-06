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

            Console.Write("Enter the temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;

        }
    }
}
