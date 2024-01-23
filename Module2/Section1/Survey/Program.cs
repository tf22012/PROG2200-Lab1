using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public int Month;
        public int Day;
        public string zodiac;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            Console.WriteLine($"Your day of birth is: {Day}");

            switch (Month)
            {
                case 1:
                    zodiac = (Day >= 20) ? "Aquarius" : "Capricorn";
                    break;
                case 2:
                    zodiac = (Day >= 20) ? "Pisces" : "Aquarius";
                    break;
                case 3:
                    zodiac = (Day >= 21) ? "Aries" : "Pisces";
                    break;
                case 4:
                    zodiac = (Day >= 21) ? "Taurus" : "Aries";
                    break;
                case 5:
                    zodiac = (Day >= 21) ? "Gemini" : "Taurus";
                    break;
                case 6:
                    zodiac = (Day >= 21) ? "Cancer" : "Gemini";
                    break;
                case 7:
                    zodiac = (Day >= 23) ? "Leo" : "Cancer";
                    break;
                case 8:
                    zodiac = (Day >= 23) ? "Virgo" : "Leo";
                    break;
                case 9:
                    zodiac = (Day >= 23) ? "Libra" : "Virgo";
                    break;
                case 10:
                    zodiac = (Day >= 23) ? "Scorpio" : "Libra";
                    break;
                case 11:
                    zodiac = (Day >= 23) ? "Sagittarius" : "Scorpio";
                    break;
                case 12:
                    zodiac = (Day >= 22) ? "Capricorn" : "Sagittarius";
                    break;
            }

            Console.WriteLine($"Your zodiac sign is: {zodiac}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryNumber());

            Console.WriteLine("What month were you born in (1-12)?");
            data.Month = int.Parse(TryNumber());

            Console.WriteLine("What day were you born on?");
            data.Day = int.Parse(TryNumber());

            data.Display();
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }

        static string TryNumber()
        {
            var question = Console.ReadLine();
            if (!Int32.TryParse(question, out _))
            {
                Console.WriteLine("You must enter an Int!");
            }
            return question;
        }
    }
}

