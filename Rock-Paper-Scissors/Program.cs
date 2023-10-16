﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*
             * user will enter his choice between rock paper and scissors
             * a random number between 0-2 will be generated
             * set each number for each choice example: (rock = 0, paper = 1, scissors = 2);
             * 
             * rock beats scissors
             * scissors beats paper
             * paper beats rock
             */

            Random random = new Random(); //generate a new Random object called random 
            String opponentChoice = ""; //declare opponentChoice and initialize it to be an Empty String
            bool playAgain = true; //variable playAgain will be used when asking the user if they want to play again

            while (playAgain) //since playAgain is true, it will run a minimum of 1 time
            {
                int num = random.Next(0, 3); //set random number ranging from 0-2 (3 exclusive) to variable num
                Console.WriteLine("Rock Paper Scissors Game\n" +
                    "Choose between Rock, Paper and Scissors and fight with the computer\n");
                Console.Write("Enter your choice: ");
                String choice = Console.ReadLine();
                choice = choice.ToLower(); //lowercase user input to prevent mismatch when comparing

                //use a switch case to name the opponentChoice based on the random number generated by num
                switch (num)
                {
                    case 0:
                        opponentChoice = "rock";
                        break;
                    case 1:
                        opponentChoice = "paper";
                        break;
                    case 2:
                        opponentChoice = "scissors";
                        break;
                }

                //pass the user input stored in choice variable to compare to each opponentChoice variable
                switch (choice)
                {
                    case "rock":
                        switch (opponentChoice)
                        {
                            case "rock":
                                Console.WriteLine("It's a tie!");
                                break;
                            case "paper":
                                Console.WriteLine("You lose!");
                                break;
                            case "scissors":
                                Console.WriteLine("You win!");
                                break;
                        }
                        break;
                    case "paper":
                        switch (opponentChoice)
                        {
                            case "rock":
                                Console.WriteLine("You win!");
                                break;
                            case "paper":
                                Console.WriteLine("It's a tie!");
                                break;
                            case "scissors":
                                Console.WriteLine("You lose!");
                                break;
                        }
                        break;
                    case "scissors":
                        switch (opponentChoice)
                        {
                            case "rock":
                                Console.WriteLine("You lose!");
                                break;
                            case "paper":
                                Console.WriteLine("You win!");
                                break;
                            case "scissors":
                                Console.WriteLine("It's a tie!");
                                break;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please choose between Rock, Paper or Scissors!");
                            break;
                        }
                }

                //set an if statement for when the user inputs a string different from the choices
                if (choice == "rock" || choice == "paper" || choice == "scissors")
                {
                    Console.WriteLine("The computer chose " + opponentChoice);
                }

                //ask the user if they want to play again
                Console.WriteLine("\nDo you want to play again? (Y/N)");
                String play = Console.ReadLine();
                play = play.ToUpper(); //set the play variable to ToUpper to prevent mismatch
                Console.Clear();
                if (play == "N") 
                {
                    playAgain = false; //if the user doesn't want to play again, set the playAgain variable to false to exit the loop
                    Console.WriteLine("Thank you for playing!");
                    return; //return is used to exit the program
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}