using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine();

            if(code == "secret")
            {
                Console.WriteLine("Authenticated");

                // Prompt user to change password after being authenticated:
                Console.WriteLine("Please enter a new pass code: ");
                // Update code variable:
                code = Console.ReadLine();

            }
            // Simplified else if with else statement 
            else
            {
                Console.WriteLine("Not Authenticated");
            }
        }
    }
}
