namespace CsharpTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array

            int[] grades = new int[5];

            for (int counter = 0; counter < grades.Length; counter++)
            {
                Console.Write("Enter grade " + (counter + 1) + ": ");
                grades[counter] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Student Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
