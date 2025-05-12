using System;

class TicTacToe
{
    static char[] board = new char[9];
    static char currentPlayer = 'X';

    static void Main()
    {
        InitializeBoard();

        while (true)
        {
            Console.Clear();
            DisplayBoard();

            Console.WriteLine($"Ход игрока {currentPlayer}. Введите номер ячейки (1-9):");
            int move = GetValidMove();

            board[move - 1] = currentPlayer;

            if (CheckWin())
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine($"Игрок {currentPlayer} выиграл!");
                break;
            }

            if (CheckDraw())
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine("Ничья!");
                break;
            }

            SwitchPlayer();
        }

        Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < board.Length; i++)
            board[i] = (i + 1).ToString()[0]; // '1'..'9'
    }

    static void DisplayBoard()
    {
        Console.WriteLine("-------------");
        for (int i = 0; i < 9; i += 3)
        {
            Console.WriteLine($"| {board[i]} | {board[i + 1]} | {board[i + 2]} |");
            Console.WriteLine("-------------");
        }
    }

    static int GetValidMove()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int move))
            {
                Console.WriteLine("Ошибка: введите число от 1 до 9.");
                continue;
            }

            if (move < 1 || move > 9)
            {
                Console.WriteLine("Ошибка: номер ячейки должен быть от 1 до 9.");
                continue;
            }

            if (board[move - 1] == 'X' || board[move - 1] == 'O')
            {
                Console.WriteLine("Ошибка: эта ячейка уже занята. Выберите другую.");
                continue;
            }

            return move;
        }
    }

    static bool CheckWin()
    {
        int[,] winPatterns = new int[,]
        {
            {0,1,2}, {3,4,5}, {6,7,8}, // строки
            {0,3,6}, {1,4,7}, {2,5,8}, // столбцы
            {0,4,8}, {2,4,6}           // диагонали
        };

        for (int i = 0; i < winPatterns.GetLength(0); i++)
        {
            int a = winPatterns[i, 0];
            int b = winPatterns[i, 1];
            int c = winPatterns[i, 2];

            if (board[a] == currentPlayer && board[b] == currentPlayer && board[c] == currentPlayer)
                return true;
        }

        return false;
    }

    static bool CheckDraw()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
