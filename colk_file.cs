using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Введите первое число:");
        double num1 = ReadDouble();

        Console.WriteLine("Введите второе число:");
        double num2 = ReadDouble();

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("+  - сложение");
        Console.WriteLine("-  - вычитание");
        Console.WriteLine("*  - умножение");
        Console.WriteLine("/  - деление");
        Console.WriteLine("%  - остаток от деления");
        Console.WriteLine("++ - инкремент (увеличить первое число на 1)");
        Console.WriteLine("-- - декремент (уменьшить первое число на 1)");

        string operation = Console.ReadLine();

        double result;
        bool validOperation = true;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно!");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                break;

            case "%":
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно!");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"Результат: {num1} % {num2} = {result}");
                }
                break;

            case "++":
                result = num1 + 1;
                Console.WriteLine($"Результат инкремента: {num1}++ = {result}");
                break;

            case "--":
                result = num1 - 1;
                Console.WriteLine($"Результат декремента: {num1}-- = {result}");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестная операция!");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine("Спасибо за использование калькулятора!");
        }
    }

    // Метод для безопасного чтения числа с консоли
    static double ReadDouble()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
            }
        }
    }
} 
