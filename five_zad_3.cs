using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // === 1. Ввод данных ===
        Console.WriteLine("Введите размеры поля N и M (через пробел):");
        string[] size = Console.ReadLine().Split();
        int N = int.Parse(size[0]); // строки
        int M = int.Parse(size[1]); // столбцы

        Console.WriteLine("Введите координаты кормушки (x y, индексы с 1):");
        string[] feederCoords = Console.ReadLine().Split();
        int feederX = int.Parse(feederCoords[0]) - 1; // переводим в 0-индексацию
        int feederY = int.Parse(feederCoords[1]) - 1;

        Console.WriteLine("Введите количество блох Q:");
        int Q = int.Parse(Console.ReadLine());

        // Сохраняем координаты блох
        List<(int x, int y)> fleas = new List<(int x, int y)>();
        Console.WriteLine("Введите координаты блох (x y, каждая с новой строки):");
        for (int i = 0; i < Q; i++)
        {
            string[] coords = Console.ReadLine().Split();
            int x = int.Parse(coords[0]) - 1; // переводим в 0-индексацию
            int y = int.Parse(coords[1]) - 1;
            fleas.Add((x, y));
        }

        // === 2. Поиск минимальных путей (BFS) ===
        // Массив расстояний (dist[i,j] = сколько прыжков от (i,j) до кормушки)
        int[,] dist = new int[N, M];
        for (int i = 0; i < N; i++)
            for (int j = 0; j < M; j++)
                dist[i, j] = -1; // -1 = клетка недостижима

        // Очередь для BFS
        Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
        queue.Enqueue((feederX, feederY)); // начинаем с кормушки
        dist[feederX, feederY] = 0; // расстояние до себя = 0

        // Все 8 возможных ходов коня
        int[] dx = { 2, 2, 1, 1, -1, -1, -2, -2 };
        int[] dy = { 1, -1, 2, -2, 2, -2, 1, -1 };

        // Основной цикл BFS
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            // Проверяем все 8 направлений
            for (int k = 0; k < 8; k++)
            {
                int nx = current.x + dx[k];
                int ny = current.y + dy[k];

                // Если (nx, ny) внутри поля и ещё не посещена
                if (nx >= 0 && nx < N && ny >= 0 && ny < M && dist[nx, ny] == -1)
                {
                    dist[nx, ny] = dist[current.x, current.y] + 1; // увеличиваем расстояние
                    queue.Enqueue((nx, ny)); // добавляем в очередь для дальнейшего обхода
                }
            }
        }

        // === 3. Проверка, могут ли все блохи добраться ===
        bool isPossible = true;
        int totalJumps = 0;

        foreach (var flea in fleas)
        {
            if (dist[flea.x, flea.y] == -1)
            {
                isPossible = false;
                break;
            }
            totalJumps += dist[flea.x, flea.y];
        }

        // === 4. Вывод результата ===
        if (!isPossible)
            Console.WriteLine("Невозможно собрать всех блох у кормушки!");
        else
            Console.WriteLine($"Минимальная сумма прыжков: {totalJumps}");
    }
}
