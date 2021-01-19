using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // LOOP
            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine("I will start learning tomorrow.");
            }
            // Waiting for Enter
            Console.ReadLine();

            // Input
            Console.Write("Enter number of repetitions: ");
            string input = Console.ReadLine();
            int howManyTimes = Convert.ToInt32(input);
            // Output
            for (int count = 0; count < howManyTimes; count++)
            {
                Console.WriteLine("I will start learning tomorrow.");
            }

            // Random number generator
            Random randomNumbers = new Random();
            // Output
            for (int count = 0; count < 20; count++)
            {
                int thrown = randomNumbers.Next(1, 6 + 1);
                Console.Write(thrown.ToString() + " ");
            }

            // Output
            Console.WriteLine("My main to-do list:");
            for (int taskNumber = 1; taskNumber <= 10; taskNumber++)
            {
                string taskText = taskNumber % 2 != 0 ? "Learning" : "Dating";
                Console.WriteLine(taskNumber.ToString() + ". " + taskText);
            }

            // Preparations
            Console.WriteLine("My main to-do list:");
            bool learning = true;
            for (int taskNumber = 1; taskNumber <= 10; taskNumber++)
            {
                // Output
                string taskText = learning ? "Learning" : "Dating";
                Console.WriteLine(taskNumber.ToString() + ". " + taskText);
                // Toggling of the flag
                learning = !learning;
            }

            // Preparations
            Console.WriteLine("My main to-do list:");
            int taskNumber = 1;
            for (int coupleCount = 0; coupleCount < 5; coupleCount++)
            {
                // Couple output and adjusting task number
                Console.WriteLine(taskNumber.ToString() + ". Learning");
                taskNumber++;
                Console.WriteLine(taskNumber.ToString() + ". Dating");
                taskNumber++;
            }

            // Preparations
            Random randomNumbers = new Random();
            double playerPoints = 0;
            double computerPoints = 0;
            int rock = 1, scissors = 2, paper = 3;
            // Inputs
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.Write("Enter number of game rounds: ");
            string input = Console.ReadLine();
            int totalRounds = Convert.ToInt32(input);
            Console.WriteLine();
            // Individual rounds
            for (int roundNumber = 0; roundNumber < totalRounds; roundNumber++)
            {
                // Computer chooses
                int computerChoice = randomNumbers.Next(1, 3 + 1);
                // Player chooses
                Console.Write("Enter R or S or P: ");
                string playerInput = Console.ReadLine();
                string playerInputUppercase = playerInput.ToUpper();
                int playerChoice = playerInputUppercase == "R" ?
                rock : (playerInputUppercase == "S" ? scissors : paper);
                // Round evaluation
                string message = "";
                if (computerChoice == rock && playerChoice == scissors ||
                      computerChoice == scissors && playerChoice == paper ||
             computerChoice == paper && playerChoice == rock)
             {
                // Computer won
                computerPoints += 1;
                message = "I won";
            }
             else
             {
                // Tie or player won
                if (computerChoice == playerChoice)
                {
                    // Tie
                    computerPoints += 0.5;
                    playerPoints += 0.5;
                    message = "Tie";
                }
                else
                {
                    // Player won
                    playerPoints += 1;
                    message = "You won";
                }
            }
            // Round output
            string playerChoiceInText = playerChoice == rock ?
            "Rock" : (playerChoice == scissors ? "Scissors" : "Paper");
            string computerChoiceInText = computerChoice == rock ?
            "Rock" : (computerChoice == scissors ? "Scissors" : "Paper");
            Console.WriteLine(playerName + ":Computer - " +
            playerChoiceInText + ":" + computerChoiceInText);
            Console.WriteLine(message);
            Console.WriteLine();
        } // End of loop for game round

         // Game evaluation
         Console.WriteLine("GAME OVER - OVERALL RESULT");
         Console.WriteLine(playerName + ":Computer - " +
         playerPoints.ToString() + ":" + computerPoints.ToString());

            for (int number = 10; number >= 1; number--)

                // Output
                for (int number = 1; number <= 10; number++)
                {
                    int secondPower = number * number;
                    Console.WriteLine(number.ToString() + " " + secondPower.
                   ToString());
                }

            // Random number generator
            Random randomNumbers = new Random();
            // Throwing as long as we have six
            int thrown;
            do
            {
                thrown = randomNumbers.Next(1, 6 + 1);
                Console.WriteLine(thrown);
            } while (thrown == 6);
        }
}
}
