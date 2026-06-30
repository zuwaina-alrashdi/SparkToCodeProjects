namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to show welcome message


            //Console.Write("Please Enter Your Name: ");
            //string userName = Console.ReadLine();

            //Console.Write("Please Enter Your Age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter your salary: ");
            //float userSalary = float.Parse(Console.ReadLine());


            //Console.WriteLine("hello " + userName + "welcome to spark");

            ////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("enter first number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            float additionResult = firstNumber + secondNumber;
            float subtractionResult = firstNumber - secondNumber;
            float multiplicationResult = firstNumber * secondNumber;
            float divisionResult = firstNumber / secondNumber;
            float reminderResult = firstNumber % secondNumber;
            bool comparisonResult = firstNumber == secondNumber;
            bool testResult = !(10 > 5); // false

            Console.WriteLine("Addition result: " + additionResult);
            Console.WriteLine("Subtraction result: " + subtractionResult);
            Console.WriteLine("multiplication result: " + multiplicationResult);
            Console.WriteLine("Division result: " + divisionResult);
            Console.WriteLine("Reminder result: " + reminderResult);
            Console.WriteLine("Comparison result: " + comparisonResult);
        }
    }
}
