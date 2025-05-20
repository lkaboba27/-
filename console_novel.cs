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
                Console.WriteLine("Вы проснулись в лесу. В лесу темно, страшно и холодно. Вам срочно нужно что-то делать, чтобы не отдать свою жизнь богу в окружении дремучих деревьев! Что же вы будете делать?");
                Console.WriteLine("1 - Пойти налево");
                Console.WriteLine("2 - Пойти направо");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    badChoices--; step++;
                    if (badChoices == -1)
                    {
                        Console.WriteLine("Фу, налево ходить плохо.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2") { goodChoices++; step++; }
                else continue;
            }
            else if (step == 1)
            {
                Console.WriteLine("Идя по извилистым тропкам, вы встретили старца, что сгорбившись опирался на свою трость.");
                Console.WriteLine("Может, хотите поболтать с ним или сделать что-нибудь ещё?");
                Console.WriteLine("1 - Поздороваться");
                Console.WriteLine("2 - Побить");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    goodChoices++; step++;
                    if (goodChoices >= 1)
                    {
                        Console.WriteLine("Дедушка тихонько ухает, походя скорее на филина, нежели на человека, и удаляется в освояси.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2")
                {
                    badChoices++; step++;
                    Console.WriteLine("Дедовская концовка: Вы выбрали избить бедного дедушку, но тот оказался не так прост и выбил из вас всю дурь своей клюкой.");
                    Console.WriteLine("Нельзя обижать старичков! Вы же не рыжий в конце-то концов.");
                    Console.ReadLine();
                    break;
                }
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
                    Console.WriteLine("Ну, теперь вы мокрый, грязный и вонючий. Минус вайб вообще.");
                    Console.ReadLine();
                }
                else continue;
            }
            else if (step == 3)
            {
                Console.WriteLine("Бродя под дождем, вы почувствовали, как у вас заурчало в животе.");
                Console.WriteLine("Но тут, как неожиданно и приятно, прямо под вашими ногами показались красные ягодки.");
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
                Console.WriteLine("Кстати, насчёт животных, мама рассказывала вам в детстве сказку про серенького волчка?");
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
                Console.WriteLine("Видимо, самое время искупаться, что думаете?");
                Console.WriteLine("1 - Обойти");
                Console.WriteLine("2 - Переплыть");
                Console.WriteLine("3 - Поймать в реке огромную рыбёху и дать ей смачного леща");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else if (choice == "3") { fishChoices++; step++; }
                if (fishChoices == 1)
                {
                    Console.WriteLine("Рыбная концовка: Александр Сергеевич испепелил вас взглядом.");
                    Console.ReadLine();
                    break;
                }
                else continue;
            }
            else if (step == 6)
            {
                Console.WriteLine("Ну, вы в любом случае мокрый от дождя, так что, что вплавь, что в обход, вам неважно, верно?");
                Console.WriteLine("Может немного погреем попи?");
                Console.WriteLine("1 - Разжечь костёр");
                Console.WriteLine("2 - Спать под открытым небом");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2")
                {
                    badChoices++; step++;
                    if (badChoices == 5)
                    {
                        Console.WriteLine("Холодная концовка: Вы легли спать мокрый без костра и просто умерли от холода. Ну, в следующий раз вы явно будете умнее.");
                        Console.ReadLine();
                        break;
                    }
                }
                else continue;
            }
            else if (step == 7)
            {
                Console.WriteLine("Вы тихо-мирно сопите.");
                Console.WriteLine("Деревья ласково шуршат над вашей головой.");
                Console.WriteLine("Костёр тепло потрескивает рядом с вами.");
                Console.WriteLine("Но тут вы слышите какой-то шорох из кустов!");
                Console.WriteLine("Что же вы будете делать?");
                Console.WriteLine("1 - Настучать недругу по голове, чтобы не втыкал");
                Console.WriteLine("2 - Продолжить сопеть и игнорировать происходящее");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2")
                {
                    badChoices++; step++;
                    Console.WriteLine("Прибежал наглый троль и украл ваше нижнее бельё.");
                    Console.WriteLine("Вам ничего за это не будет, но теперь вы остались в лесу буквально с голой задницей.");
                    Console.ReadLine();
                }
                else continue;
            }
            else if (step == 8)
            {
                Console.WriteLine("Что же, могу вас поздравить, вы пережили ночь.");
                Console.WriteLine("**Правда, какой ценой...**");
                Console.WriteLine("Ладно, в любом случае вы живы, а это самое главное, так что ваше путешествие продолжается!");
                Console.WriteLine("Продолжая своё шествие по лесу, вы натыкаетесь на домик.");
                Console.WriteLine("Он крайне тёмный, подозрительный и веет от него чем-то вообще не хорошим.");
                Console.WriteLine("Ваши действия?");
                Console.WriteLine("1 - Войти внутрь, несмотря на страх.");
                Console.WriteLine("2 - Быть разумнее и не делать глупостей");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else continue;
            }
            else if (step == 9)
            {
                Console.WriteLine("Итак, вы в доме.");
                Console.WriteLine("Ну, если честно, он ровно такой же стрёмный, как и снаружи.");
                Console.WriteLine("Внутри настолько темно, будто вы застряли где-то у кого-то с тёмной кожей.");
                Console.WriteLine("Надо придумать что-то, чтобы облегчить себе жизнь.");
                Console.WriteLine("1 - Попытаться найти что-то на ощупь");
                Console.WriteLine("2 - Попытаться найти осветительный предмет");
                Console.WriteLine("3 - Уйти отсюда по добру по здорову, пока не стало поздно");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else if (choice == "3") { badChoices++; step++; }
                else continue;
            }
            else if (step == 10)
            {
                Console.WriteLine("К счастью вашей глупенькой головы, вам удалось найти карту.");
                Console.WriteLine("Вы радостно ахаете, сжимая папир в руках.");
                Console.WriteLine("Развернувшись к выходу, на этот раз даже без приключений.");
                Console.WriteLine("Может, стоит как-нибудь повернуть карту?");
                Console.WriteLine("1 - Повернуть вертикально");
                Console.WriteLine("2 - Повернуть горизонтально");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else continue;
            }
            else if (step == 11)
            {
                Console.WriteLine("Следуя ориентирам на карте, вы уверенно идёте вперёд.");
                Console.WriteLine("Вдруг из-за деревьев выходит прекрасная женщина, ласково маня вас рукой.");
                Console.WriteLine("Может, стоит подойти?");
                Console.WriteLine("1 - Убрать карту и приблизиться к красавице");
                Console.WriteLine("2 - Хмыкнуть и уткнувшись в карту идти дальше");
                string choice = Console.ReadLine();
                if (choice == "1") { badChoices++; step++; }
                else if (choice == "2") { goodChoices++; step++; }
                else continue;
            }
            else if (step == 12)
            {
                Console.WriteLine("ДА, ТУДА ЭТУ ЖЕНЩИНУ!!!");
                Console.WriteLine("*кхм* Не отвлекаясь на посторонние раздражители, вы смело продолжаете свой путь.");
                Console.WriteLine("Деревья опять шелестят, но навстречу вам выходит дровосек!");
                Console.WriteLine("Вас снова пытаются ввести в заблуждение и сожрать, не смейте вестись!!");
                Console.WriteLine("1 - Истерически визжать и убегать сверкая пятками");
                Console.WriteLine("2 - Насупить брови, но остаться на месте");
                string choice = Console.ReadLine();
                if (choice == "1") { badChoices++; step++; }
                else if (choice == "2") { goodChoices++; step++; }
                else continue;
            }
            else if (step == 13)
            {
                Console.WriteLine("Видимо, с мужчинами вам везёт больше, коли после встречи с дровосеком вы выжили.");
                Console.WriteLine("Идя дальше, вы видите гигантский пень, на котором растут аппетитно выглядящие, но, возможно, ядовитые грибы.");
                Console.WriteLine("Серьёзно, в этом лесу всё пытается вас убить, вам это ЕЩЁ НЕ НАДОЕЛО?");
                Console.WriteLine("Может, закончим на этом?");
                Console.WriteLine("Вы просто пойдёте по своим делам, а я буду отдыхать.");
                Console.WriteLine("1 - Сдаться и закончить всё здесь");
                Console.WriteLine("2 - Настоящие герои всегда идут жрать грибы");
                string choice = Console.ReadLine();
                if (choice == "1") { badChoices++; step++; }
                else if (choice == "2") { goodChoices++; step++; }
                else continue;
            }
            else if (step == 14)
            {
                Console.WriteLine("Вы... буквально... отказались от конца ради...");
                Console.WriteLine("1 - ...ради чего?");
                Console.WriteLine("2 - Просто идём дальше");
                string choice = Console.ReadLine();
                if (choice == "1") { badChoices++; step++; }
                else if (choice == "2") { goodChoices++; step++; }
                else continue;
            }
            else if (step == 15)
            {
                Console.WriteLine("Вас встречает странный зверь с рогами. Он явно не рад вас видеть.");
                Console.WriteLine("1 - Попробовать подружиться");
                Console.WriteLine("2 - Убежать");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else continue;
            }
            else if (step == 16)
            {
                Console.WriteLine("Вы наконец-то выходите к поляне, на которой стоит красивый замок.");
                Console.WriteLine("1 - Войти в замок");
                Console.WriteLine("2 - Обойти замок стороной");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else continue;
            }
            else if (step == 17)
            {
                Console.WriteLine("В замке вас встречает король. Он предлагает вам испытание.");
                Console.WriteLine("1 - Принять испытание");
                Console.WriteLine("2 - Отказаться");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else continue;
            }
            else if (step == 18)
            {
                Console.WriteLine("Испытание оказалось несложным, и вы его прошли.");
                Console.WriteLine("1 - Попросить награду");
                Console.WriteLine("2 - Поблагодарить и уйти");
                string choice = Console.ReadLine();
                if (choice == "1") { goodChoices++; step++; }
                else if (choice == "2") { badChoices++; step++; }
                else continue;
            }
            else if (step == 19)
            {
                Console.WriteLine("Ваше приключение подходит к концу. Что вы выберете?");
                Console.WriteLine("1 - Остаться в замке");
                Console.WriteLine("2 - Вернуться домой");
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
                if (fishChoices == 1)
                    Console.WriteLine("Рыбная концовка: Александр Сергеевич испепелил вас взглядом.");
                else if (badChoices >= 5)
                    Console.WriteLine("Плохая концовка: Вы слишком много ошибались и не смогли выбраться из леса.");
                else if (goodChoices >= 15)
                    Console.WriteLine("Лучшая концовка: Вы стали героем королевства!");
                else if (goodChoices >= 10)
                    Console.WriteLine("Хорошая концовка: Вы нашли новый дом и новых друзей.");
                else
                    Console.WriteLine("Обычная концовка: Ваше приключение закончилось, но всё ещё впереди!");
                Console.WriteLine("Конец. Нажмите любую клавишу для выхода.");
                Console.ReadKey();
                break;
            }
        }
    }
}
