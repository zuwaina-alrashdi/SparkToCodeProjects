namespace CsharpTask2_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer

            Console.Write("Enter a starting number: ");
            int startNumber = int.Parse(Console.ReadLine());

            for (int counter = startNumber; counter >= 1; counter--)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine("Liftoff!");
        }
    }
}
