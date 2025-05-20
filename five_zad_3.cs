using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int[] numbers = Array.ConvertAll(parts, int.Parse);

        int count = 0;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
