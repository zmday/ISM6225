using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Input
            //Console.Write("Enter password: ");
            //string enteredPassword = Console.ReadLine();
            //// Password check
            //if (enteredPassword == "friend")
            //{
            //    Console.WriteLine("Password is OK, please enter");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect password");
            //}
            //// Waiting for Enter
            //Console.ReadLine();

            //// Correct password
            //string correctPassword = "friend";
            //// Input
            //Console.Write("Enter password: ");
            //string enteredPassword = Console.ReadLine();

            //// Password check
            //if (enteredPassword != correctPassword)
            //{
            //    Console.WriteLine("Incorrect password");
            //}
            //else
            //{
            //    Console.WriteLine("Password is OK, please enter");
            //}
            //// Waiting for Enter
            //Console.ReadLine();

            //// Input
            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();
            //// Determining length
            //int wordLength = word.Length;
            //// Checking length
            //if (wordLength <= 4)
            //{
            //    Console.WriteLine("Word is short (at most 4 characters)");
            //}
            //else
            //{
            //    Console.WriteLine("Word is long (more than 4 characters)");
            //}

            //// Input
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            //// Evaluation
            //if (number > 0)
            //{
            //    Console.WriteLine("The number is positive");
            //}
            //else
            //{
            //    Console.WriteLine("The number is NOT positive");
            //}

            //// Remainder calculation
            //int remainderAfterDivisionByTwo = number % 2;
            //// Evaluation
            //if (remainderAfterDivisionByTwo == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}

            //// Converting to small letters
            //string name1inSmall = name1.ToLower();
            //string name2inSmall = name2.ToLower();
            //// Evaluating
            //if (name1inSmall == name2inSmall)
            //{
            //    Console.WriteLine("You have entered the same names");
            //}
            //else
            //{
            //    Console.WriteLine("You have entered different names");
            //}

            //// Evaluating
            //int greater = Math.Max(number1, number2);

            //// Appending extension (ONLY IN CASE OF NEED)
            //if (!fileName.ToLower().EndsWith(".png"))
            //{
            //    fileName += ".png";
            //}

            //// Random number generator
            //Random randomNumbers = new Random();
            //// Random number 0/1 and its transformation
            //int randomNumber = randomNumbers.Next(0, 1 + 1);
            //if (randomNumber == 0)
            //{
            //    Console.WriteLine("Head tossed");
            //}
            //else

            // Checking entered value
            DateTime today = DateTime.Today;
            if (enteredDeadline < today)
            {
                Console.WriteLine("Error! You have entered date in the past.");
            }
            else

                // Checking
                bool ok = true;
            if (invoiceDate < paymentDate)
            {
                Console.WriteLine("Invoice date cannot precede payment date.");
                ok = false;
            }
            if (invoiceDate > paymentDate.AddDays(15))
            {
                Console.WriteLine("Invoice cannot be issued later than 15 days
               after payment.");
               
                ok = false;

                if (inputInSmall == "yes" || inputInSmall == "no")
                {
                    Console.WriteLine("OK.");
                }
                // At the beginning, we set 1st number as minimum
                int minimum = number1;
                // Is not 2nd number less than present minimum?
                if (number2 < minimum)
                {
                    minimum = number2;
                }
                // Is not 3rd number less than present minimum?
                if (number3 < minimum)
                {
                    minimum = number3;
                }

                // Random number generator
                Random randomNumbers = new Random();
                // Random number 0/1 and its transformation
                int randomNumber = randomNumbers.Next(0, 1 + 1);
                string message = randomNumber == 0 ? "Head tossed" : "Tail tossed";
                Console.WriteLine(message);

            }
}
