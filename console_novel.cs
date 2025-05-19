using System;

class Program
{
    static void Main()
    {
        int step = 0;
        int goodChoices = 0;
        int badChoices = 0;
        int fishChoices = 0;
        bool end = false;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Шаг {step + 1}");

            if (step == 0)
            {
                Console.WriteLine("Вы проснулись в лесу. В лесу темно, страшно и холодно. Вам срочно нужно что-то делать, чтобы не отдать свою жизнь богу в окружении дремучих деревьев! Что же вы будите делать?");
                Console.WriteLine("1 - Пойти налево");
                Console.WriteLine("2 - Пойти направо");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    badChoices--; step++;
                    if (badChoices == -1)
                    {
                        Console.WriteLine("Фу, на лево ходить плохо.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2") { goodChoices++; step++; }

                else continue;
            }
            else if (step == 1)
            {
                Console.WriteLine("Идя по извилистым тропкам, вы встретили, страца, что сгорбившись опирался на свою трость. Может, хотите поболтать с ним или сделать что-нибудь ещё?");
                Console.WriteLine("1 - Поздороваться");
                Console.WriteLine("2 - Побить");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    goodChoices++; step++;
                    if (goodChoices == 1)
                    {
                        Console.WriteLine("Дедушка тихонько ухает, походя скорее на филина, нежели на человека и удаляется в освоясии.");
                        Console.ReadLine(); 
                    }
                }
                else if (choice == "2") { badChoices++; step++; }
                if (badChoices == 1) {
                    Console.WriteLine("Дедовская концовка: Вы выбрали избить бедного дедушку, но тот оказался не так прост и выбил из вас всю дурь своей клюкой.");
                    Console.WriteLine("Нельзя обижать старичков! Вы же не рыжий в конце то концов.");
                     break; } 
                else continue;
            }
            else if (step == 2)
            {
                Console.WriteLine("Похоже, ваши действия не привели ни к чему хорошему, чтобы вы не сделали.");
                Console.WriteLine("Ах, как метафорично, но не время думать о поэзии, потому что небеса разверзлись прямо над вами и грянул гром!");
                Console.WriteLine("Надо что-то делать");
                Console.WriteLine("1 - Найти укрытие");
                Console.WriteLine("2 - Продолжить идти");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2")
                {
                    badChoices++; step++;
                    if (badChoices == 1)
                    {
                        Console.WriteLine("Ну, теперь вы мокрый, грязный и вонючий. Минус вайб Вообще");
                        Console.ReadLine();
                    }
                }
                else continue;
            
            }
            else if (step == 3)
                {
                    Console.WriteLine("Бродя под дождем вы почувствовали, как у вас заурчало в животе, но тут, как неожиданно и приятно, прямо под вашими ногами показались красные ягодки.");
                    Console.WriteLine("Потащите каку в рот или, всё же, будете чуть умнее животного?");
                    Console.WriteLine("1 - Съесть ягоды");
                    Console.WriteLine("2 - Игнорировать");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 4)
                {
                    Console.WriteLine("Кстати, насчёт животных, мама рассказывала вам в детсве сказку про серенького волчка?");
                    Console.WriteLine("Потому что он сейчас, буквально, имеет приятную возможность откусить вам бочок.");
                    Console.WriteLine("1 - Убежать");
                    Console.WriteLine("2 - Постоять на месте");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 5)
                {
                Console.WriteLine("Видимо, вы любимец бога, потому что всё ещё остаётесь в живых, да и дождик уже перестал капать, а вы как раз нашли речку.");
                    Console.WriteLine("Видимо, самое время искупаться, что думаете? 1 - Обойти, 2 - Переплыть , 3 - Поймать в реке огромную рыбёху и дать ей смачного леща");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else if (choice == "3") { fishChoices++; step++; }
                    if (fishChoices == 1)
                    {
                        Console.WriteLine("Рыбная концовка: Александр Сергеевич испепелил вас взглядом.");
                        break;
                    }

                    else continue;
                }


                else if (step == 6)
                {
                    Console.WriteLine("Ну, вы в любом случае мокрый от дождя, так что, что в плавь, что в обход, вам неважно, верно? Может немного погреем попи?");
                    Console.WriteLine("1 - Разжечь костёр");
                    Console.WriteLine("2 - Спать под открытым небом");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    if (badChoices == 7)
                    {
                        Console.WriteLine("Холодная концовка: Вы легли спать мокрый без костра и просто умерли от холода. Ну, в следующий раз, вы явно будете умнее.");
                        break;
                    }
                    else continue;
                }
                else if (step == 7)
                {
                    Console.WriteLine("Мирно. 1 - Проверить, что это, 2 - Игнорировать");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 8)
                {
                    Console.WriteLine("Вы нашли заброшенный дом. 1 - Войти внутрь, 2 - Обойти стороной");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 9)
                {
                    Console.WriteLine("В доме темно. 1 - Искать свечу, 2 - Идти дальше на ощупь");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 10)
                {
                    Console.WriteLine("Вы нашли карту. 1 - Взять карту, 2 - Оставить карту");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 11)
                {
                    Console.WriteLine("Вы встретили охотника. 1 - Попросить помощи, 2 - Спрятаться");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 12)
                {
                    Console.WriteLine("Появилась буря. 1 - Найти укрытие, 2 - Продолжать идти");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 13)
                {
                    Console.WriteLine("Вы нашли мост. 1 - Перейти мост, 2 - Искать другой путь");
                    string choice = Console.ReadLine();
                    if (choice == "1") { badChoices++; step++; }
                    else if (choice == "2") { goodChoices++; step++; }
                    else continue;
                }
                else if (step == 14)
                {
                    Console.WriteLine("Вас окружили волки. 1 - Драться, 2 - Бежать");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 15)
                {
                    Console.WriteLine("Вы нашли пещеру. 1 - Войти, 2 - Обойти");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 16)
                {
                    Console.WriteLine("В пещере темно. 1 - Использовать факел, 2 - Идти вслепую");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 17)
                {
                    Console.WriteLine("Вы нашли сундук. 1 - Открыть, 2 - Оставить");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; step++; }
                    else if (choice == "2") { badChoices++; step++; }
                    else continue;
                }
                else if (step == 18)
                {
                    Console.WriteLine("Вы нашли реку. 1 - Переплыть, 2 - Построить плот");
                    string choice = Console.ReadLine();
                    if (choice == "1") { badChoices++; step++; }
                    else if (choice == "2") { goodChoices++; step++; }
                    else continue;
                }
                else if (step == 19)
                {
                    Console.WriteLine("Вы дошли до замка. 1 - Войти, 2 - Обойти стороной");
                    string choice = Console.ReadLine();
                    if (choice == "1") { goodChoices++; end = true; }
                    else if (choice == "2") { badChoices++; end = true; }
                    else continue;
                }
                else
                {
                    end = true;
                }

            if (end)
            {
                Console.Clear();

                if (goodChoices >= 9 && badChoices <= 1)
                    Console.WriteLine("Концовка 1: Вы стали героем королевства! (лучшая)");
                else if (goodChoices >= 7)
                    Console.WriteLine("Концовка 2: Вы спасли деревню.");
                else if (goodChoices >= 5)
                    Console.WriteLine("Концовка 3: Вы нашли клад.");
                else if (goodChoices == 4)
                    Console.WriteLine("Концовка 4: Вы выжили, но остались ни с чем.");
                else if (goodChoices == 3)
                    Console.WriteLine("Концовка 5: Вас чуть не поймали разбойники.");
                else if (goodChoices == 2)
                    Console.WriteLine("Концовка 6: Вы потерялись в лесу.");
                else if (goodChoices == 1)
                    Console.WriteLine("Концовка 7: Вас спасли случайные путники.");
                else if (badChoices >= 9)
                    Console.WriteLine("Концовка 8: Вас поймали разбойники.");
                else if (badChoices >= 7)
                    Console.WriteLine("Концовка 9: Вы заблудились и не нашли выход.");
                else
                    Console.WriteLine("Концовка 10: Ваше приключение закончилось неожиданно.");
                
                Console.WriteLine("Конец. Нажмите любую клавишу для выхода.");
                Console.ReadKey();
                break;
            }
        }
    }
}

