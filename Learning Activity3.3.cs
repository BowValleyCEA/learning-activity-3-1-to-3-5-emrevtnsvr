using System;

namespace TicTacToe
{
    class Program
    {
        static void LearningActivity33(int[,] board)
        {
            // first we check the rows
            for (int i = 0; i < 3; i++)
            {
                // we check if all the numbers in the row are the same
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                {
                    // if they are the same and not 0, then somone won
                    Console.WriteLine("Player " + board[i, 0] + " wins!");
                    return;
                }
            }

            // now we check the columns
            for (int i = 0; i < 3; i++)
            {
                // we check if all the numbers in the column are the same
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
                {
                    // if they are the same and not 0, then somone won
                    Console.WriteLine("Player " + board[0, i] + " wins!");
                    return;
                }
            }

            // now we check the diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
            {
                // if they are the same and not 0, then somone won
                Console.WriteLine("Player " + board[0, 0] + " wins!");
                return;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
            {
                // if they are the same and not 0, then somone won
                Console.WriteLine("Player " + board[0, 2] + " wins!");
                return;
            }

            // if we didnt find a winner, then we say thats its a tie
            Console.WriteLine("No winner.");
        }

        static void Main(string[] args)
        {
            int[,] board = {
                {1, 2, 1},
                {2, 1, 2},
                {1, 2, 1}
            };
            LearningActivity33(board);
            Console.ReadLine(); // add this line to prevent the console from closing immediately
        }
    }
}