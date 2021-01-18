using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace Data_Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Output of text to the user
            //Console.WriteLine("I am starting to program in C#.");
            //Console.WriteLine(1 + 1);
            ////joining texts
            //Console.WriteLine("I have started to program" + " in C#.");

            //// Multiline output
            //Console.WriteLine("First line\r\nSecond line");
            //// I prefer specifying "Enter" in more human form
            //Console.WriteLine("First line" + Environment.NewLine + "Second line");
            //// Text containing a quote
            //Console.WriteLine("The letter started so sweet: \"My Darling\"");
            //// Unicode characters, in this case Greek beta
            //Console.WriteLine("If the font knows, here is Greek beta: \u03B2");
            //// Backslashes themselves need to be doubled
            // Console.WriteLine("Path to desktop on my computer: " + "C:\\Users\\vystavel\\Desktop");

            //pre-formatted text
            //Bob Dylan...
            //    Console.WriteLine(@"
            //Yes, and how many times
            //can a man turn his head
            //and pretend
            //that he just doesn't see?
            //");

            // Declaration of a variable to store text
            //string message;
            //// Storing a value in prepared variable (assignment statement)
            //message = "I can't live with you.";
            //// Another variable (initialized with some value)
            //string anotherMessage = "I can't live without you.";
            //// Output of variables
            //Console.WriteLine(message);
            //Console.WriteLine(anotherMessage);

            //you can use @ to turn off escape sequences instead of backlashes- good for file paths
            //numbers entered without quotes

            //// Decimal numbers have always limited precision
            //double notCompletelyOne = 0.999999999999999999;
            //Console.WriteLine("Cool:" + notCompletelyOne);

            //// Two logical (Boolean) variables
            //bool thePrettiestGirlLovesMe = true;
            //bool iAmHungry = false;
            //// Use exclamation mark to negate logical value
            //bool iAmNotHungry = !iAmHungry;

            //// Variable of DateTime type, at first empty
            //DateTime now;
            //// Storing of current date and time into our variable
            //now = DateTime.Now;
            //// Output
            //Console.WriteLine("Now is " + now);

            // // Current date and time (using single statement)
            // DateTime now = DateTime.Now;
            // // Picking up individual components
            // int day = now.Day;
            // int month = now.Month;
            // int year = now.Year;
            // int hours = now.Hour;
            // int minutes = now.Minute;
            // int seconds = now.Second;
            // DateTime justDateWithoutTime = now.Date;


            // // Today's date
            // DateTime today = DateTime.Today;
            // // Output
            // Console.WriteLine("Today is " + today.ToLongDateString());

            // // Today's date
            // DateTime today = DateTime.Today;
            // // Tomorrow's date
            // DateTime tomorrow = today.AddDays(1);
            // // Output
            // Console.WriteLine("Today is " + today.ToShortDateString() + ".");
            // Console.WriteLine("I will start learning on " + tomorrow.
            //ToShortDateString() + ".");

            // // Creating random number generator object
            // Random randomNumbers = new Random();
            // // Repeatedly throwing a die
            // int number1 = randomNumbers.Next(1, 6 + 1);
            // int number2 = randomNumbers.Next(1, 6 + 1);
            // int number3 = randomNumbers.Next(1, 6 + 1);
            // // Output
            // Console.WriteLine("Thrown numbers: " +
            // number1 + ", " +
            // number2 + ", " +
            // number3);

            // // 1. CORRECT SOLUTION
            // // Creating random number generator object
            // //for different values use same random number generator
            // Random randomNumbers = new Random();
            // // Repeatedly throwing two dice
            // int correctNumber11 = randomNumbers.Next(1, 6 + 1);
            // int correctNumber12 = randomNumbers.Next(1, 6 + 1);
            // int correctNumber21 = randomNumbers.Next(1, 6 + 1);
            // int correctNumber22 = randomNumbers.Next(1, 6 + 1);
            // int correctNumber31 = randomNumbers.Next(1, 6 + 1);
            // int correctNumber32 = randomNumbers.Next(1, 6 + 1);
            // // Output
            // Console.WriteLine("CORRECTLY");
            // Console.WriteLine("Thrown couples: " +
            // correctNumber11 + "-" + correctNumber12 + ", " +
            //Figure 6 - 5.Rolling dice three times
            //Chapter 6 Using Object Actions
            //76

            // correctNumber21 + "-" + correctNumber22 + ", " +
            // correctNumber31 + "-" + correctNumber32);
            // // 2. INCORRECT SOLUTION
            // // Two random number generators
            // Random randomNumbers1 = new Random();
            // Random randomNumbers2 = new Random();
            // // Repeatedly throwing two dice
            // int incorrectNumber11 = randomNumbers1.Next(1, 6 + 1);
            // int incorrectNumber12 = randomNumbers2.Next(1, 6 + 1);
            // int incorrectNumber21 = randomNumbers1.Next(1, 6 + 1);
            // int incorrectNumber22 = randomNumbers2.Next(1, 6 + 1);
            // int incorrectNumber31 = randomNumbers1.Next(1, 6 + 1);
            // int incorrectNumber32 = randomNumbers2.Next(1, 6 + 1);
            // // Output
            // Console.WriteLine(); // empty line
            // Console.WriteLine("INCORRECTLY");
            // Console.WriteLine("Thrown couples: " +
            // incorrectNumber11 + "-" + incorrectNumber12 + ", " +
            // incorrectNumber21 + "-" + incorrectNumber22 + ", " +
            // incorrectNumber31 + "-" + incorrectNumber32);

            // // Finding path to the desktop
            // string pathToDesktop = Environment.GetFolderPath(Environment.
            //SpecialFolder.Desktop);
            // // Output
            // Console.WriteLine("Path to your desktop: " + pathToDesktop);

            // // Some text to try things on
            // string text = "This is the last day of our acquaintance";
            // // What e.g. can be done with texts
            // Console.WriteLine("Original text: " + text);
            // Console.WriteLine("Number of characters: " + text.Length);
            // Console.WriteLine("In uppercase: " + text.ToUpper());
            // Console.WriteLine("Does it contain word \"last\"? " + text.
            //Contains("last"));

            // // Some number
            // int number = 1234;
            // // Conversion to text
            // //string numberAsText = number; // DOES NOT WORK!
            // string numberAsText = number.ToString();
            // // Output
            // Console.WriteLine("Output of number: " + number);
            // Console.WriteLine("Output of text: " + numberAsText);

            // double amount = 1234.56;
            // double anotherAmount = 789;
            // int wholeNumber = 1234567;
            // // Formatted outputs
            // Console.WriteLine("Separating thousands and millions + money to cents");
            // //1,234.56
            // Console.WriteLine(amount.ToString("N2"));
            // //789.00
            // Console.WriteLine(anotherAmount.ToString("N2"));
            // //1,234,567
            // Console.WriteLine(wholeNumber.ToString("N0"));

            // Whole and decimal number
            int wholeNumber = 1234567;
            double decimalNumber = 1234567.89;
            // Localization objects
            CultureInfo czech = new CultureInfo("cs-CZ");
            CultureInfo american = new CultureInfo("en-US");
            // Localized output
            Console.WriteLine("Whole number - Czech: " + wholeNumber.
           ToString("N0", czech));
            Console.WriteLine("Whole number - American: " + wholeNumber.
           ToString("N0", american));
            Console.WriteLine("Decimal number - Czech: " + decimalNumber.
           ToString("N2", czech));
            Console.WriteLine("Decimal number - American: " + decimalNumber.
           ToString("N2", american));

            // Waiting for Enter-- doesn't close immediately
            Console.ReadLine();
        }
    }
}
