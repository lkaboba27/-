using System;
using System.Collections.Generic;

class InteractiveNovel
{
    // Текущий шаг истории
    static int currentStep = 1;

    // Счётчик хороших и плохих выборов для определения концовки
    static int goodChoices = 0;
    static int badChoices = 0;

    // Главный метод
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в интерактивную новеллу!");
        Console.WriteLine("Вы можете в любой момент ввести 'exit' для выхода.\n");

        while (true)
        {
            switch (currentStep)
            {
                case 1:
                    Step1();
                    break;
                case 2:
                    Step2();
                    break;
                case 3:
                    Step3();
                    break;
                case 4:
                    Step4();
                    break;
                case 5:
                    Step5();
                    break;
                case 6:
                    Step6();
                    break;
                case 7:
                    Step7();
                    break;
                case 8:
                    Step8();
                    break;
                case 9:
                    Step9();
                    break;
                case 10:
                    Step10();
                    break;
                case 11:
                    Step11();
                    break;
                case 12:
                    Step12();
                    break;
                case 13:
                    Step13();
                    break;
                case 14:
                    Step14();
                    break;
                case 15:
                    Step15();
                    break;
                case 16:
                    Step16();
                    break;
                case 17:
                    Step17();
                    break;
                case 18:
                    Step18();
                    break;
                case 19:
                    Step19();
                    break;
                case 20:
                    Step20();
                    break;
                default:
                    // Концовка в зависимости от выбора
                    ShowEnding();
                    return;
            }
        }
    }

    // Метод для чтения выбора пользователя с проверкой
    static string GetChoice(params string[] validChoices)
    {
        while (true)
        {
            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "exit")
            {
                Console.WriteLine("Спасибо за игру! До новых встреч.");
                Environment.Exit(0);
            }

            foreach (var choice in validChoices)
            {
                if (input == choice.ToLower())
                    return input;
            }

            Console.WriteLine("Некорректный выбор. Попробуйте снова.");
        }
    }

    // Пример шага 1
    static void Step1()
    {
        Console.WriteLine("\nШаг 1: Вы просыпаетесь в таинственном лесу. Что вы делаете?");
        Console.WriteLine("1) Осмотреться вокруг.");
        Console.WriteLine("2) Попытаться найти тропинку.");
        Console.WriteLine("3) Позвать на помощь.");

        string choice = GetChoice("1", "2", "3");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Вы замечаете странные следы на земле.");
                goodChoices++;
                currentStep = 2;
                break;
            case "2":
                Console.WriteLine("Вы находите тропинку, ведущую вглубь леса.");
                goodChoices++;
                currentStep = 3;
                break;
            case "3":
                Console.WriteLine("Ваши крики привлекают внимание хищника!");
                badChoices++;
                currentStep = 4;
                break;
        }
    }

    static void Step2()
    {
        Console.WriteLine("\nШаг 2: Следы ведут к заброшенной хижине. Что делать?");
        Console.WriteLine("1) Войти в хижину.");
        Console.WriteLine("2) Обойти хижину и продолжить путь.");
        Console.WriteLine("3) Вернуться назад.");

        string choice = GetChoice("1", "2", "3");

        switch (choice)
        {
            case "1":
                Console.WriteLine("В хижине вы находите карту.");
                goodChoices++;
                currentStep = 5;
                break;
            case "2":
                Console.WriteLine("Вы натыкаетесь на ловушку и получаете рану.");
                badChoices++;
                currentStep = 6;
                break;
            case "3":
                Console.WriteLine("Вы возвращаетесь к месту пробуждения.");
                currentStep = 1;
                break;
        }
    }

    static void Step3()
    {
        Console.WriteLine("\nШаг 3: Тропинка ведет к реке. Что делать?");
        Console.WriteLine("1) Переплыть реку.");
        Console.WriteLine("2) Идти вдоль берега.");
        Console.WriteLine("3) Построить плот.");

        string choice = GetChoice("1", "2", "3");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Река слишком быстрая, вы едва спасаетесь.");
                badChoices++;
                currentStep = 7;
                break;
            case "2":
                Console.WriteLine("Вы находите мост и переходите реку.");
                goodChoices++;
                currentStep = 8;
                break;
            case "3":
                Console.WriteLine("Вы успешно строите плот и переправляетесь.");
                goodChoices++;
                currentStep = 9;
                break;
        }
    }

    static void Step4()
    {
        Console.WriteLine("\nШаг 4: Хищник нападает! Вы пытаетесь убежать.");
        Console.WriteLine("1) Забраться на дерево.");
        Console.WriteLine("2) Сражаться.");
        Console.WriteLine("3) Притвориться мертвым.");

        string choice = GetChoice("1", "2", "3");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Вы спасаетесь, но падаете и ломаете ногу.");
                badChoices++;
                currentStep = 10;
                break;
            case "2":
                Console.WriteLine("Вы побеждаете хищника, но получаете рану.");
                goodChoices++;
                badChoices++;
                currentStep = 11;
                break;
            case "3":
                Console.WriteLine("Хищник уходит, вы целы.");
                goodChoices++;
                currentStep = 12;
                break;
        }
    }

    // Далее добавьте шаги 5-20 по аналогии, например:

    static void Step5()
    {
        Console.WriteLine("\nШаг 5: Используя карту, вы выбираете путь.");
        Console.WriteLine("1) Идти на восток.");
        Console.WriteLine("2) Идти на запад.");
        Console.WriteLine("3) Остановиться и отдохнуть.");

        string choice = GetChoice("1", "2", "3");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 13;
                break;
            case "2":
                badChoices++;
                currentStep = 14;
                break;
            case "3":
                badChoices++;
                currentStep = 15;
                break;
        }
    }

    static void Step6()
    {
        Console.WriteLine("\nШаг 6: Рана мешает вам идти дальше.");
        Console.WriteLine("1) Попытаться перевязать рану.");
        Console.WriteLine("2) Игнорировать и идти дальше.");
        Console.WriteLine("3) Позвать на помощь.");

        string choice = GetChoice("1", "2", "3");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 16;
                break;
            case "2":
                badChoices++;
                currentStep = 17;
                break;
            case "3":
                badChoices++;
                currentStep = 18;
                break;
        }
    }

    // ... Добавьте остальные шаги (7-20) аналогично

    static void Step7()
    {
        Console.WriteLine("\nШаг 7: Вы устали и решаете отдохнуть.");
        Console.WriteLine("1) Найти безопасное место.");
        Console.WriteLine("2) Заснуть прямо на месте.");

        string choice = GetChoice("1", "2");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 19;
                break;
            case "2":
                badChoices++;
                currentStep = 20;
                break;
        }
    }

    // Для упрощения, шаги 8-20 можно сделать аналогично с разными вариантами и переходами

    static void Step8()
    {
        Console.WriteLine("\nШаг 8: Вы встречаете странника.");
        Console.WriteLine("1) Поговорить с ним.");
        Console.WriteLine("2) Игнорировать.");

        string choice = GetChoice("1", "2");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 13;
                break;
            case "2":
                badChoices++;
                currentStep = 14;
                break;
        }
    }

    static void Step9()
    {
        Console.WriteLine("\nШаг 9: Плот плывет быстро, но вы устали.");
        Console.WriteLine("1) Продолжать плыть.");
        Console.WriteLine("2) Отдохнуть на плоту.");

        string choice = GetChoice("1", "2");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 15;
                break;
            case "2":
                badChoices++;
                currentStep = 20;
                break;
        }
    }

    static void Step10()
    {
        Console.WriteLine("\nШаг 10: Сломанная нога мешает вам двигаться.");
        Console.WriteLine("1) Попытаться лечить ногу.");
        Console.WriteLine("2) Игнорировать боль и идти дальше.");

        string choice = GetChoice("1", "2");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 16;
                break;
            case "2":
                badChoices++;
                currentStep = 18;
                break;
        }
    }

    static void Step11()
    {
        Console.WriteLine("\nШаг 11: Рана кровоточит, нужно срочно лечиться.");
        Console.WriteLine("1) Использовать найденные травы.");
        Console.WriteLine("2) Игнорировать рану.");

        string choice = GetChoice("1", "2");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 19;
                break;
            case "2":
                badChoices++;
                currentStep = 20;
                break;
        }
    }

    static void Step12()
    {
        Console.WriteLine("\nШаг 12: Вы в безопасности, но голодны.");
        Console.WriteLine("1) Искать еду.");
        Console.WriteLine("2) Отдохнуть и ждать помощи.");

        string choice = GetChoice("1", "2");

        switch (choice)
        {
            case "1":
                goodChoices++;
                currentStep = 13;
                break;
            case "2":
                badChoices++;
                currentStep = 14;
                break;
        }
    }

    // Шаги 13-20 - для примера можно сделать простыми переходами к концовкам

    static void Step13()
    {
        Console.WriteLine("\nШаг 13: Вы нашли выход из леса!");
        currentStep = 21; // Концовка
    }

    static void Step14()
    {
        Console.WriteLine("\nШаг 14: Вы заблудились еще глубже.");
        currentStep = 22; // Концовка
    }

    static void Step15()
    {
        Console.WriteLine("\nШаг 15: Вы устали и решили сдаться.");
        currentStep = 23; // Концовка
    }

    static void Step16()
    {
        Console.WriteLine("\nШаг 16: Вы успешно лечите рану и восстанавливаетесь.");
        currentStep = 24; // Концовка
    }

    static void Step17()
    {
        Console.WriteLine("\nШаг 17: Рана ухудшается, вы теряете сознание.");
        currentStep = 25; // Концовка
    }

    static void Step18()
    {
        Console.WriteLine("\nШаг 18: Никто не пришел на помощь, вы остались одни.");
        currentStep = 26; // Концовка
    }

    static void Step19()
    {
        Console.WriteLine("\nШаг 19: Вы нашли безопасное место и пережили ночь.");
        currentStep = 27; // Концовка
    }

    static void Step20()
    {
        Console.WriteLine("\nШаг 20: Вы заснули и не проснулись.");
        currentStep = 28; // Концовка
    }

    // Метод вывода концовок
    static void ShowEnding()
    {
        Console.WriteLine("\n--- Концовка ---");

        switch (currentStep)
        {
            case 21:
                Console.WriteLine("Поздравляем! Вы выбрались из леса и спаслись. Хорошая концовка!");
                break;
            case 22:
                Console.WriteLine("Вы заблудились навсегда. Плохая концовка.");
                break;
            case 23:
                Console.WriteLine("Вы сдались и остались в лесу. Плохая концовка.");
                break;
            case 24:
                Console.WriteLine("Вы вылечились и нашли путь домой. Хорошая концовка!");
                break;
            case 25:
                Console.WriteLine("Вы потеряли сознание и не проснулись. Плохая концовка.");
                break;
            case 26:
                Console.WriteLine("Вы остались одни и никто не пришел на помощь. Плохая концовка.");
                break;
            case 27:
                Console.WriteLine("Вы пережили ночь и теперь готовы к новым приключениям. Хорошая концовка!");
                break;
            case 28:
                Console.WriteLine("Вы уснули и не проснулись. Плохая концовка.");
                break;
            default:
                // Если по каким-то причинам currentStep не совпадает с концовкой
                if (goodChoices > badChoices)
                    Console.WriteLine("Вы сделали много хороших выборов и спаслись. Хорошая концовка!");
                else
                    Console.WriteLine("Ваши решения привели к печальному исходу. Плохая концовка.");
                break;
        }

        Console.WriteLine("\nСпасибо за игру!");
        Environment.Exit(0);
    }
}

Изучение циклов 
Упражнение 1: Расчёт вклада с циклом for
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


Упражнение 2: То же, но с циклом while
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

Упражнение 3: Таблица умножения
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







Упражнение 4: Ввод двух чисел с проверкой диапазона и вывод их произведения
Csharp
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

