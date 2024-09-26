//LA 3.3:

using System;
public static class TicTacToe
{
    static readonly int[,] board = new[,] {
        {0, 1, 0},
        {0, 1, 2},
        {0, 1, 2},
    };

    public static void Run()
    {
        int winningPlayer = 0;
        bool isDone = false;
        

        for (int currentPlayer = 1; currentPlayer <= 2 && !isDone; currentPlayer++)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    || (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
                {
                    winningPlayer = currentPlayer;
                    isDone = true;
                    break;
                }
            }

            //Check diagnols:

            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                || (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            {
                winningPlayer = currentPlayer;
                break;
            }
        }
        Console.WriteLine("Tic-Tac-Toe Result: \n");
        Console.WriteLine(winningPlayer + " wins the Tic-Tac-Toe game!");
    }
}



