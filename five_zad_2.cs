using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] graph = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            string[] parts = Console.ReadLine().Split();
            for (int j = 0; j < N; j++)
                graph[i, j] = int.Parse(parts[j]);
        }

        string[] ends = Console.ReadLine().Split();
        int start = int.Parse(ends[0]) - 1;
        int end = int.Parse(ends[1]) - 1;

        Console.WriteLine(BFS(graph, start, end, N));
    }

    static int BFS(int[,] graph, int start, int end, int N) //bfs это поиск по уровням, от ближайших к более дальним точкам, чтобы быстро найти кратчайший путь
    {
        Queue<int> queue = new Queue<int>(); //создание новой очереди для хранения элементов типа int
        bool[] visited = new bool[N];
        int[] dist = new int[N];
        for (int i = 0; i < N; i++) dist[i] = -1;

        queue.Enqueue(start);
        visited[start] = true;
        dist[start] = 0;

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();
            if (u == end) return dist[u];

            for (int v = 0; v < N; v++)
            {
                if (graph[u, v] == 1 && !visited[v])
                {
                    visited[v] = true;
                    dist[v] = dist[u] + 1;
                    queue.Enqueue(v);
                }
            }
        }
        return -1; // Путь не найден
    }
}
