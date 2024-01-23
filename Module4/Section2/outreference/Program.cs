using System;

namespace outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;

            Console.WriteLine(x);

            Five(out x);

            Console.WriteLine(x);

            // Modifications //

            Double(ref x);

            Console.WriteLine(x);

            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            test = "Ronan";

            outDouble = 0.0;
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);


        }

        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        // Modifications //
        static void Double(ref int a)
        {
            // Note: When using out it will not accept variable 'a' without initializing it!
            // So it is better to use  ref instead of out in this function:
            a = a * 2;
            Console.WriteLine(a);
        }

        static bool ParseDouble(string testString, out double outDouble)
        {
            // outDouble should be initalized here as we use 'out' in the function signature:
            outDouble = 0.0;
            // Define/Initalize result variable:
            bool result = false;
            try
            {
                if (double.Parse(testString).GetType() == outDouble.GetType())
                {
                    outDouble = double.Parse(testString);
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
