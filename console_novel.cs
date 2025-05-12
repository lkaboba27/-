using System;

class SimpleTextNovel
{
    static void Main()
    {
        Console.WriteLine("Вы просыпаетесь в тёмной комнате...");
        
        bool isAlive = true;
        int choice;
        int lastChoice = -1; // Переменная для хранения последнего выбора (изначально -1, т.к. его не может быть)
        
        while(isAlive)
        {
            Console.WriteLine("\nЧто вы будете делать?");
            Console.WriteLine("1 - Осмотреться");
            Console.WriteLine("2 - Крикнуть");
            Console.WriteLine("3 - Попытаться выйти");
            Console.WriteLine("0 - Сдаться и закончить игру");
            
            if(int.TryParse(Console.ReadLine(), out choice)) //используется метод, который преобразует строку в число и передает это значение переменной 
            {
                if(choice == lastChoice) // Если выбор совпадает с предыдущим
                {
                    Console.WriteLine("Вы уже выбирали этот вариант! Попробуйте что-то ещё.");
                    continue; // Пропускаем оставшуюся часть цикла и начинаем заново
                }
                
                lastChoice = choice; // Запоминаем текущий выбор для следующего шага
                
                if(choice == 1)
                {
                    Console.WriteLine("Вы видите дверь и окно.");
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Никто не ответил... Тишина.");
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Вы нашли выход! Поздравляем!");
                    isAlive = false;
                }
                else if(choice == 0)
                {
                    Console.WriteLine("Игра окончена. До свидания!");
                    isAlive = false;
                }
                else
                {
                    Console.WriteLine("Неизвестная команда, попробуйте ещё раз.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число.");
            }
        }
    }
}
