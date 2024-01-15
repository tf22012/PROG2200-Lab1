using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            // Two Custom Questions:

            // Prompt user for favorite colour & store it in a variable called favoriteColour:
            Console.WriteLine("What is your favorite colour?");
            var favoriteColour = Console.ReadLine();

            // Prompt user for favorite animal & store it in a variable called favoriteAnimal:
            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            // Output custom questions:
            Console.WriteLine($"Your favorite colour is {favoriteColour}.");
            Console.WriteLine($"Your favorite animal is {favoriteAnimal}.");
        }
    }
}
