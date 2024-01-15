using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            // Removed Arrays "studentNames" & "studentGrades"
            // Created new 2D Array called "studentNamesAndGrades":
            var studentNamesAndGrades = new string[studentCount, 2]; 

            // Populate 2D Array with student info recieved as input:
            for (int i = 0; i < studentCount; i++)
            {
                // Retrieve Student Name:
                Console.Write("Student Name: ");
                studentNames[i][0] = Console.ReadLine();

                // Retrieve Student Grade:
                Console.Write("Student Grade: ");
                studentGrades[i][1] = Console.ReadLine();
                
            }

            // Output Names & Grades for each student:
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Name: {studentNamesAndGrades[i][0]}, Grade: {studentNamesAndGrades[i][1]}");
            }
        }
    }
}
