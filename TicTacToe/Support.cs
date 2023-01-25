using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3
{
    public class Support
    {
        //Method 1: Print current board based on board array received
        public void PrintBoard(string[] board)
        {
            Console.WriteLine(" " + board[1] + " | " + board[2] + " | " + board[3] + " ");
            Console.WriteLine("-----------");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6] + " ");
            Console.WriteLine("-----------");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9] + " ");

        }

        //Method 2: Determine if winner and return the letter of the winner based on updated board array received

        public string Winner(string[] board)
        {
            string winningString = "";

            
            //Horizontal Wins
            if (board[1] == board[2] && board[2] == board[3])
            {
                winningString = board[1];
            }

            else if (board[4] == board[5] && board[5] == board[6])
            {
                winningString = board[4];
            }

            else if (board[7] == board[8] && board[8] == board[9])
            {
                winningString = board[7];
            }
            
            //Vertical Wins
            else if (board[1] == board[4] && board[4] == board[7])
            {
                winningString = board[1];
            }

            else if (board[2] == board[5] && board[5] == board[8])
            {
                winningString = board[2];
            }

            else if (board[3] == board[6] && board[6] == board[9])
            {
                winningString = board[3];
            }

            //Diagonal Wins
            else if (board[1] == board[5] && board[5] == board[9])
            {
                winningString = board[1];
            }

            else if (board[3] == board[5] && board[5] == board[7])
            {
                winningString = board[3];
            }

            if (winningString == null) 
            {
                winningString = "S";
            }
            return winningString;
        }
    }
}
