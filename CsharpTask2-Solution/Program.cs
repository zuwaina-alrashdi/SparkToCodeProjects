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

            Console.Write("Enter a positive whole number: ");
            int positiveNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int counter = 1; counter <= positiveNumber; counter++)
            {
                sum = sum + counter;
            }

            Console.WriteLine("The sum is: " + sum);

        }
    }
}
