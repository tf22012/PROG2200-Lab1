using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a loop to repeat pattern 5 times:
            for (int i = 1; i <= 5; i++)
            {
                // Inner loop will print 1 - 10 & 10 - 1:
                for (int j = 1; j <= 20; j++)
                {
                    // Define currentNumber variable:
                    int currentNumber;

                    // Calculate currentNumber based on the value of j:
                    if (j <= 10)
                    {
                        currentNumber = j;
                    }
                    else
                    {
                        currentNumber = 20 - j + 1; // + 1 need to stay in range! 10 - 1
                    }
                    // Print currentNumber:
                    Console.WriteLine(currentNumber);
                }
            }
        }
    }
}
