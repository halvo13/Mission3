using System;

namespace Mission3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] board = new string[10]; // Create game board array to store player's choices
            int Player1Flag = 1; // Initialize varaibles
            int totalTurns = 0;
            int winnerFlag = 0;

            // Bring in Support Class
            Support support = new Support();

            // Welcome user to game
            Console.WriteLine("Welcome to Tic - Tac - Toe!");

            // Play Game
            // Ask each player for choice and update gameboard array
            while (totalTurns < 9 && winnerFlag == 0)
            {
                // Player 1 Turn
                if (Player1Flag == 1)
                {
                    int choice = 0;

                    support.PrintBoard(board); // Print Board
                    Console.WriteLine("Player 1 Pick an available spot to place an ‘X’ "); // Ask for player choice
                    choice = Convert.ToInt32(Console.ReadLine()); // Update player choice
                    Console.WriteLine("\n");

                    if (board[choice] == "X" || board[choice] == "O")
                    {
                        Console.WriteLine("Space already taken.Try again.");
                    }
                    else
                    {
                        board[choice] = "X"; // Add choice to array
                        Player1Flag = 0;
                        totalTurns++;
                    }
                }

                // Check Winner
                string winner = support.Winner(board); // Call supporting class

                if (winner == "X")
                {
                    Console.WriteLine("Player 1 won!"); // Notify player winner
                    winnerFlag = 1;
                    break;
                }
                else if (winner == "O")
                {
                    Console.WriteLine("Player 2 won!");
                    winnerFlag = 1;
                    break;
                }           

                // Player 2 Turn
                if (totalTurns < 9 && Player1Flag == 0)
                {
                    int choice = 0;
                    
                    support.PrintBoard(board); // Print Board
                    Console.WriteLine("Player 2 Pick an available spot to place an 'O' "); // Ask for player choice
                    choice = Convert.ToInt32(Console.ReadLine()); // Update player choice
                    Console.WriteLine("\n");

                    if (board[choice] == "X" || board[choice] == "O")
                    {
                        Console.WriteLine("Space already taken.Try again.");
                    }
                    else
                    {
                        board[choice] = "O"; // Add choice to array
                        Player1Flag = 1;
                        totalTurns++;
                    }
                }
                
                // Check Winner
                winner = support.Winner(board); // Call supporting class
                if (winner == "X")
                {
                    Console.WriteLine("Player 1 won!"); // Notify player winner
                    winnerFlag = 1;
                    break;
                }
                else if (winner == "O")
                {
                    Console.WriteLine("Player 2 won!");
                    winnerFlag = 1;
                    break;
                }
            }

            // Print Board after a win
            if (winnerFlag == 1)
            {
                support.PrintBoard(board);
            }
            // Print Board after tie
            if (winnerFlag == 0)
            {
                Console.WriteLine("Game ended in tie.");
                support.PrintBoard(board);
            }
        }
    } // End Main
}