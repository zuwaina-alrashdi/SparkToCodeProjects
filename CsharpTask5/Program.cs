namespace CsharpTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array

            //int[] grades = new int[5];

            //for (int counter = 0; counter < grades.Length; counter++)
            //{
            //    Console.Write("Enter grade " + (counter + 1) + ": ");
            //    grades[counter] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Student Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            /////////////////////////////////////////////////////////////////

            // Task 2 - Dynamic To-Do List

            //List<string> tasks = new List<string>();

            //for (int counter = 0; counter < 5; counter++)
            //{
            //    Console.Write("Enter task " + (counter + 1) + ": ");
            //    tasks.Add(Console.ReadLine());
            //}

            //Console.WriteLine("To-Do List:");

            //foreach (string task in tasks)
            //{
            //    Console.WriteLine("- " + task);
            //}

            /////////////////////////////////////////////////////////////////

            // Task 3 - Browsing History Stack

            //Stack<string> browserHistory = new Stack<string>();

            //for (int counter = 0; counter < 3; counter++)
            //{
            //    Console.Write("Enter website URL " + (counter + 1) + ": ");
            //    browserHistory.Push(Console.ReadLine());
            //}

            //browserHistory.Pop();

            //Console.WriteLine("Current page: " + browserHistory.Peek());

            /////////////////////////////////////////////////////////////////

            // Task 4 - Customer Service Queue

            //Queue<string> customers = new Queue<string>();

            //for (int counter = 0; counter < 3; counter++)
            //{
            //    Console.Write("Enter customer name " + (counter + 1) + ": ");
            //    customers.Enqueue(Console.ReadLine());
            //}

            //string servedCustomer = customers.Dequeue();

            //Console.WriteLine("Served customer: " + servedCustomer);

            /////////////////////////////////////////////////////////////////

            // Task 5 - Array Grade Range

            //int[] grades = new int[5];

            //for (int counter = 0; counter < grades.Length; counter++)
            //{
            //    Console.Write("Enter grade " + (counter + 1) + ": ");
            //    grades[counter] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(grades);

            //int sum = 0;

            //for (int counter = 0; counter < grades.Length; counter++)
            //{
            //    sum = sum + grades[counter];
            //}

            //double average = (double)sum / grades.Length;

            //Console.WriteLine("Lowest grade: " + grades[0]);
            //Console.WriteLine("Highest grade: " + grades[grades.Length - 1]);
            //Console.WriteLine("Average grade: " + average);

            /////////////////////////////////////////////////////////////////

            // Task 6 - Filtered Shopping List

            List<string> shoppingList = new List<string>();

            string item = "";

            while (item != "done")
            {
                Console.Write("Enter an item (or type 'done' to finish): ");
                item = Console.ReadLine();

                if (item != "done")
                {
                    shoppingList.Add(item);
                }
            }

            Console.WriteLine("Shopping List:");

            foreach (string shoppingItem in shoppingList)
            {
                Console.WriteLine("- " + shoppingItem);
            }

            Console.Write("Enter an item to remove: ");
            string removeItem = Console.ReadLine();

            shoppingList.Remove(removeItem);

            Console.WriteLine("Updated Shopping List:");

            foreach (string shoppingItem in shoppingList)
            {
                Console.WriteLine("- " + shoppingItem);
            }

        }
    }
}
