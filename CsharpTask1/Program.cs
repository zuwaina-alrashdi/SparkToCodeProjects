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

            Console.Write("Please Enter the Rectangle Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Please Enter the Rectangle Width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("perimeter: " + perimeter);

        }
    }
}
