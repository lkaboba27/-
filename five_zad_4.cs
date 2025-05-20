using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(1);
            return;
        }
        int t1 = 1;
        int t2 = 1;
        int totalTime = t1 + t2;

        for (int i = 3; i <= n; i++)
        {
            int tCurrent = t1 + t2;
            totalTime += tCurrent;
            t1 = t2;
            t2 = tCurrent;
        }

        Console.WriteLine(totalTime);
    }
}
