using System;
using static System.Console;

namespace ROCKPAPERSCISSORS
{
    class Program

    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;
                while (scorePlayer < 3 && scoreCPU < 3)

                {
                    Write("Choose between Rock, Paper, Scissor: \n");
                    inputPlayer = ReadLine();

                    Random rnd = new Random(); 
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            WriteLine("Computer chose Rock");
                            if (inputPlayer == "Rock")
                            {
                                WriteLine("Draw");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                WriteLine("Player wins! \n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Scissor")
                            {
                                WriteLine("CPU Wins!\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            WriteLine("Computer chose Paper");
                            if (inputPlayer == "Rock")
                            {
                                WriteLine("CPU won");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                WriteLine("Draw \n");

                            }
                            else if (inputPlayer == "Scissor")
                            {
                                WriteLine("Player Wins!\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissor";
                            WriteLine("Computer chose Scissor");
                            if (inputPlayer == "Rock")
                            {
                                WriteLine("Player Wins");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                WriteLine("CPU wins! \n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Scissor")
                            {
                                WriteLine("Draw!\n");

                            }
                            break;
                        default:
                            WriteLine("invalid entry");
                            break;
                    }
                    WriteLine("\nScores \t\t Player: {0}, \t CPU: {1}  ", scorePlayer, scoreCPU);
                }

                //if player wins thrice
                if (scorePlayer == 3)
                {
                    WriteLine("Player wins");
                }

                //if CPU wins thrice
                else if (scoreCPU == 3)
                {
                    WriteLine("CPU wins");
                }
                else
                {

                }
                WriteLine("Do you wanna play again? y/n");
                string loop = ReadLine();
                if (loop == "y" || loop =="Y")
                {
                    playAgain = true;

                }
                else if (loop == "n" || loop == "N")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }

    }
}
