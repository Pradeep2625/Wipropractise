using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizcodingqsns
{
    internal class StudentManagementPortal
    {
        static void Mail(string[] args)
        {
            // Prompt the user to enter student details
            Console.WriteLine("Enter student's name:");
            // Complete Step 3:............
            string name = Console.ReadLine();

            Console.WriteLine("Enter student's age:");
            // Complete Step 4:............
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter student's grade:");
            // Complete Step 5:............
            string grade = Console.ReadLine();
            // Display the entered student details
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine(
                $"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            // Complete Step 6:............
            
    }
}
