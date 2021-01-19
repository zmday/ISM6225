using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Reading single line of text (until user presses Enter key)-- user input
            //string input = Console.ReadLine();
            //// Outputting the input
            //Console.WriteLine(input);
            //// Waiting for Enter
            //Console.ReadLine();

            //// Hinting user what we want from her
            //Console.Write("Enter a sentence (and press Enter): ");
            //// Reading line of text
            //string input = Console.ReadLine();
            //// Repeating to the output-- not necessary for problems
            //Console.WriteLine("You have entered: " + input);
            //// Waiting for Enter
            //Console.ReadLine();

            //// Prompting the user
            //Console.Write("How old are you? ");
            //// Reading line of text
            //string input = Console.ReadLine();
            //// CONVERTING TO NUMBER (of entered text)-- int input
            //int enteredNumber = Convert.ToInt32(input);
            //// Output of entered number
            //Console.WriteLine("Your age: " + enteredNumber);
            //// Waiting for Enter
            //Console.ReadLine();

            //// CONVERING TO NUMBER (of entered text)
            //int yearOfBirth = Convert.ToInt32(input);
            //// Finding this year
            //DateTime today = DateTime.Today;
            //int thisYear = today.Year;
            //// Calculating age
            //int age = thisYear - yearOfBirth;

            // // Calculations
            // double sum = number1 + number2;
            // double difference = number1 - number2;
            // double product = number1 * number2;
            // double quotient = number1 / number2;

            // // Calculation and output of sine value
            // double angleInRadians = angleInDegrees * Math.PI / 180;
            // double result = Math.Sin(angleInRadians);
            // Console.WriteLine("Sine of the angle is: " + result);

            // // Calculation and output of square root
            // Console.WriteLine("Square root of the number is: " + Math.
            //Sqrt(number));

            //// Integer calculations-- modulus
            //int integerQuotient = number1 / number2;
            //int remainder = number1 % number2;

            // // Calculations -- percents
            // double coeficient1 = 1 - merchantPercents / 100.0;
            // double coeficient2 = 1 - distributorPercents / 100.0;
            // double wholesalePrice = customerPrice * coeficient1;
            // double priceAfterCommissionSubtraction = wholesalePrice * coeficient2;
            // double merchantIncome = customerPrice - wholesalePrice;
            // double distributorIncome = wholesalePrice -
            //priceAfterCommissionSubtraction;
            // double producerIncome = priceAfterCommissionSubtraction;


            // // Rounding just for output
            // Console.WriteLine("First amount displayed with cent precision: " +
            //amount1.ToString("N2"));
            // Console.WriteLine("Second amount displayed with cent precision: " +
            //amount2.ToString("N2"));
            // Console.WriteLine();
            // // Rounding for further calculations + informative output
            // double roundedAmount1 = Math.Round(amount1, 2); // 2 = two decimal
            // places
            // double roundedAmount2 = Math.Round(amount2, 2);
            // Console.WriteLine("First amount rounded to cents: " + roundedAmount1);
            // Console.WriteLine("Second amount rounded to cents: " + roundedAmount2);
            // Console.WriteLine();

            //// Input
            //Console.Write("Enter (decimal) amount in dollars: ");
            //string input = Console.ReadLine();
            //double amount = Convert.ToDouble(input);
            //// To dollars
            //double nearest = Math.Round(amount);
            //double alwaysDown = Math.Floor(amount);
            //double alwaysUp = Math.Ceiling(amount);
            //Console.WriteLine();
            //Console.WriteLine("To dollars");
            //Console.WriteLine("----------");
            //Console.WriteLine("Nearest : " + nearest);
            //Console.WriteLine("Always down: " + alwaysDown);
            //Console.WriteLine("Always up : " + alwaysUp);
            //// To cents
            //nearest = Math.Round(amount, 2);
            //alwaysDown = Math.Floor(100 * amount) / 100;
            //alwaysUp = Math.Ceiling(100 * amount) / 100;
            //Console.WriteLine();
            //Console.WriteLine("To cents");
            //Console.WriteLine("--------");
            //Console.WriteLine("Nearest : " + nearest);
            //Console.WriteLine("Always down: " + alwaysDown);
            //Console.WriteLine("Always up : " + alwaysUp);
            //// To hundreds of dollars
            //nearest = 100 * Math.Round(amount / 100);
            //alwaysDown = 100 * Math.Floor(amount / 100);
            //alwaysUp = 100 * Math.Ceiling(amount / 100);
            //Console.WriteLine();
            //Console.WriteLine("To hundreds of dollars");
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Nearest : " + nearest);
            //Console.WriteLine("Always down: " + alwaysDown);
            //Console.WriteLine("Always up : " + alwaysUp);
            //// Waiting for Enter
            //Console.ReadLine();

            //// Calculations
            //double divisor = 1 + vatRate / 100.0;
            //double calculatedPriceWithoutVat = customerPrice / divisor;
            //double priceWithoutVat = Math.Round(calculatedPriceWithoutVat, 2);
            //double vat = customerPrice - priceWithoutVat;

            // // Conversion to DateTime object
            // DateTime enteredDate = Convert.ToDateTime(input);
            // // Some calculations
            // DateTime followingDay = enteredDate.AddDays(1);
            // DateTime previousDay = enteredDate.AddDays(-1);

            // // Calculations
            // int enteredYear = enteredDate.Year;
            // int enteredMonth = enteredDate.Month;
            // DateTime firstDayOfMonth = new DateTime(enteredYear, enteredMonth, 1);
            // DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // // Date input -- quarters
            // Console.Write("Enter a date: ");
            // string input = Console.ReadLine();
            // DateTime enteredDate = Convert.ToDateTime(input);
            // // Calculations
            // int enteredYear = enteredDate.Year;
            // int enteredMonth = enteredDate.Month;
            // int numberOfQuarter = (enteredMonth + 2) / 3;
            // int monthOfQuarterStart = 3 * numberOfQuarter - 2;
            // DateTime firstDayOfQuarter = new DateTime(enteredYear,
            //monthOfQuarterStart, 1);
            // DateTime lastDayOfQuarter = firstDayOfQuarter.AddMonths(3).AddDays(-1);
            // // Outputs
            // Console.WriteLine();
            // Console.WriteLine("Corresponding quarter: " +
            // "number-" + numberOfQuarter +
            // ", from " + firstDayOfQuarter.ToShortDateString() +
            // " to " + lastDayOfQuarter.ToShortDateString());

            // // Today
            // DateTime today = DateTime.Today;
            // // Date difference
            // TimeSpan difference = today - dateOfBirth;
            // int numberOfDays = difference.Days;

            // // Number values -- different typesxz
            // Console.WriteLine("Signed whole numbers");
            // Console.WriteLine("--------------------");
            // Console.WriteLine("sbyte: " + sbyte.MinValue + " to " +
            //sbyte.MaxValue);
            // Console.WriteLine("short: " + short.MinValue + " to " +
            //short.MaxValue);
            // Console.WriteLine("int: " + int.MinValue + " to " + int.MaxValue);
            // Console.WriteLine("long: " + long.MinValue + " to " + long.MaxValue);
            // Console.WriteLine();
            // Console.WriteLine("Unsigned whole numbers");
            // Console.WriteLine("----------------------");
            // Console.WriteLine("byte: " + byte.MinValue + " to " + byte.MaxValue);
            // Console.WriteLine("ushort: " + ushort.MinValue + " to " + ushort.
            //MaxValue);
            // Console.WriteLine("unit: " + uint.MinValue + " to " + uint.MaxValue);
            // Console.WriteLine("ulong: " + ulong.MinValue + " to " + ulong.
            //MaxValue);
            // Console.WriteLine();
            // Console.WriteLine("Basic decimal numbers");
            // Console.WriteLine("---------------------");
            // Console.WriteLine("float: " + float.MinValue + " to " + float.MaxValue);
            // Console.WriteLine("double: " + double.MinValue + " to " + double.
            //MaxValue);
            // Console.WriteLine();
            // Console.WriteLine("Exact decimal numbers");
            // Console.WriteLine("---------------------");
            // Console.WriteLine("decimal: " + decimal.MinValue + " to " + decimal.
            //MaxValue);

            // Console.WriteLine("byte: " + sizeof(byte));

            // //long num calc
            // long millionInLong = million;
            // long correctResult = millionInLong * millionInLong;
            // long correctResultAlternatively = (long)million * (long)million;

            number += 10; // same as number = number + 10;

            // Preparation - variables to accumulate intermediate results
            string inOriginalOrder = "";
            string inReversedOrder = "";
            // Input of the first person
            Console.Write("Enter first person: ");
            string person = Console.ReadLine();
            // Appending the first person to intermediate result
            inOriginalOrder += person + Environment.NewLine;
            inReversedOrder = person + Environment.NewLine + inReversedOrder;
        }
    }
}
