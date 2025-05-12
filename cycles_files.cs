//Упражнение 1: Расчёт вклада с циклом for

using System;

class Exercise1
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = int.Parse(Console.ReadLine());

        decimal sum = deposit;

        for (int i = 1; i <= months; i++)
        {
            sum += sum * 0.07m; // 7% от текущей суммы
        }

        Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {sum:F2}");
    }
}


//Упражнение 2: То же, но с циклом while

using System;

class Exercise2
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = int.Parse(Console.ReadLine());

        decimal sum = deposit;
        int i = 1;

        while (i <= months)
        {
            sum += sum * 0.07m; // 7% от текущей суммы
            i++;
        }

        Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {sum:F2}");
    }
}

//Упражнение 3: Таблица умножения

using System;

class Exercise3
{
    static void Main()
    {
        Console.WriteLine("Таблица умножения 1-10:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}"); // Вывод с выравниванием по 4 символам
            }
            Console.WriteLine();
        }
    }
}







//Упражнение 4: Ввод двух чисел с проверкой диапазона и вывод их произведения

using System;

class Exercise4
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите первое число (от 0 до 10):");
            bool isNum1Valid = int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Введите второе число (от 0 до 10):");
            bool isNum2Valid = int.TryParse(Console.ReadLine(), out int num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, вводите целые числа.");
                continue;
            }

            if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
            {
                Console.WriteLine("Введённые числа недопустимы. Попробуйте снова.");
                continue;
            }

            int product = num1 * num2;
            Console.WriteLine($"Результат умножения: {num1} * {num2} = {product}");
            break; // Выход из цикла, если числа корректны
        }
    }
}
