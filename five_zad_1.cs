using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        long[,] dp = new long[N, M];
        dp[0, 0] = 1;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                // Ход 2 вниз, 1 вправо
                if (i >= 2 && j >= 1)
                    dp[i, j] += dp[i - 2, j - 1];
                
                // Ход 1 вниз, 2 вправо
                if (i >= 1 && j >= 2)
                    dp[i, j] += dp[i - 1, j - 2];
            }
        }

        Console.WriteLine(dp[N - 1, M - 1]);
    }
}
