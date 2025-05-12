//Задача 1: Сумма чисел в списке

csharp
using System.Collections.Generic;

public static int SumList(List<int> numbers)
{
    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return sum;
}
//Задача 2: Проверка на палиндром

csharp
public static bool IsPalindrome(string s)
{
    int left = 0;
    int right = s.Length - 1;
    while (left < right)
    {
        if (s[left] != s[right])
            return false;
        left++;
        right--;
    }
    return true;
}
//Задача 3: Факториал числа

csharp
public static long Factorial(int n)
{
    if (n < 0)
        throw new ArgumentException("Число должно быть неотрицательным");
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}
//Задача 4: Поиск максимального элемента в списке

csharp
using System.Collections.Generic;

public static int MaxElement(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
        throw new ArgumentException("Список не должен быть пустым");
    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
            max = num;
    }
    return max;
}
//Задача 5: Удаление дубликатов из списка

csharp
using System.Collections.Generic;
using System.Linq;

public static List<int> RemoveDuplicates(List<int> numbers)
{
    return numbers.Distinct().ToList();
}
