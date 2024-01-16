using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a new variable called "counter"
             * "counter" will keep track of how many times we have counter from 1 - 10 & 10 - 1:
            */
            var counter = 1;

            // Removed parent for loop and replaced it with an if statement:
            // ERROR: Does not repeat 5 times FIX!!!
            if (counter <= 5)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                // Increase counter varible by 1:
                counter++;
            }
        }
    }
}
