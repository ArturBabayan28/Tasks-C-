//Task1
using System;
class Program
{
    static void Main()
    {
        int[,] board = new int[8, 8];
        Console.Write("Enter the row (0-7)");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the column (0-7)");
        int col = Convert.ToInt32(Console.ReadLine());
        Moves(board, row, col);
        Output(board);
    }

    static void Moves(int[,] board, int row, int col)
    {
        int[] dx = { 1, 2, 2, 1, -1, -2, -2, -1 };
        int[] dy = { 2, 1, -1, -2, -2, -1, 1, 2 };
        board[row,col] = 2;

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + dx[i];
            int newCol = col + dy[i];

            if (IsValidMove(newRow, newCol))
            {
                board[newRow, newCol] = 1;
            }
        }
    }

    static bool IsValidMove(int row, int col)
    {
        return row >= 0 && row < 8 && col >= 0 && col < 8;
    }

    static void Output(int[,] board)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if(board[i,j] == 0){
                    Console.Write("0 ");  
                }
                else{
                    Console.Write("1 ");  
                }
            }
            Console.WriteLine();
        }
    }
} 

//Task 2
using System;
class Program
{
    static void Main()
    {
        int[,] board = new int[8, 8];
        Console.Write("Enter the row (0-7) ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the column (0-7) ");
        int col = Convert.ToInt32(Console.ReadLine());
        Moves(board, row, col);
        Output(board);
    }
    static void Moves(int[,] board, int row, int col)
    {
        for (int i = 0; i < 8; i++)
        {
            if (i != row)
            {
                board[i, col] = 1;
            }
            if (i != col)
            {
                board[row, i] = 1;
            }
            if (IsValidMove(row + i, col + i))
            {
                board[row + i, col + i] = 1;
            }
            if (IsValidMove(row - i, col + i))
            {
                board[row - i, col + i] = 1;
            }
            if (IsValidMove(row + i, col - i))
            {
                board[row + i, col - i] = 1;
            }
            if (IsValidMove(row - i, col - i))
            {
                board[row - i, col - i] = 1;
            }
        }
        board[row, col] = 2;
    }
    static bool IsValidMove(int row, int col)
    {
        return row >= 0 && row < 8 && col >= 0 && col < 8;
    }
    static void Output(int[,] board)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (board[i, j] == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write("1 ");
                }
            }
            Console.WriteLine();
        }
    }
}
