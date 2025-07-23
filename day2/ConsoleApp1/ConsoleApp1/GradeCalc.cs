using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GradeCalc
    {
        void calcualateGrade(int marks)
        {
            if(marks<0 || marks > 100)
            {
                Console.WriteLine("Invalid marks. Please enter marks between 0 and 100.");
            }
            else if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: E");
            }
            else
            {
                Console.WriteLine("Grade: F for fail");

            }

        }
        static void Main(string[] args)
        {
            GradeCalc gc = new GradeCalc();
            Console.WriteLine("Enter marks from 1 to 100");
            Console.WriteLine("Enter marks for subject 1:");
            int subject1 = Convert.ToInt32(Console.ReadLine());
            gc.calcualateGrade(subject1);
            Console.WriteLine("Enter marks for subject 2:");
            int subject2 = Convert.ToInt32(Console.ReadLine());
            gc.calcualateGrade(subject2);
            Console.WriteLine("Enter marks for subject 3:");
            int subject3 = Convert.ToInt32(Console.ReadLine());
            gc.calcualateGrade(subject3);
            Console.WriteLine("Enter marks for subject 4:");
            int subject4 = Convert.ToInt32(Console.ReadLine());
            gc.calcualateGrade(subject4);


        }
    }
}
