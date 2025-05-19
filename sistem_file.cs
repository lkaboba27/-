using System;
using System.IO;

class FileManager
{
    static string currentDirectory = Directory.GetCurrentDirectory();

    static void Main()
    {
        Console.WriteLine("Простой файловый менеджер");
        
        while (true)
        {
            Console.WriteLine("\nТекущая папка: " + currentDirectory);
            Console.WriteLine("1. Просмотр содержимого");
            Console.WriteLine("2. Перейти в папку");
            Console.WriteLine("3. Вернуться в родительскую папку");
            Console.WriteLine("4. Создать папку");
            Console.WriteLine("5. Создать файл");
            Console.WriteLine("6. Просмотреть файл");
            Console.WriteLine("7. Удалить файл/папку");
            Console.WriteLine("8. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowDirectoryContents();
                    break;
                case "2":
                    EnterDirectory();
                    break;
                case "3":
                    GoToParentDirectory();
                    break;
                case "4":
                    CreateDirectory();
                    break;
                case "5":
                    CreateFile();
                    break;
                case "6":
                    ViewFile();
                    break;
                case "7":
                    DeleteItem();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
        }
    }

    // 1. Показать содержимое текущей папки
    static void ShowDirectoryContents()
    {
        Console.WriteLine("\nСодержимое папки:");
        
        // Показываем все подпапки
        foreach (var dir in Directory.GetDirectories(currentDirectory))
        {
            Console.WriteLine("[Папка] " + Path.GetFileName(dir));
        }
        
        // Показываем все файлы
        foreach (var file in Directory.GetFiles(currentDirectory))
        {
            Console.WriteLine("[Файл]  " + Path.GetFileName(file));
        }
    }

    // 2. Перейти в выбранную папку
    static void EnterDirectory()
    {
        Console.Write("Введите имя папки: ");
        string dirName = Console.ReadLine();
        string newPath = Path.Combine(currentDirectory, dirName);

        if (Directory.Exists(newPath))
        {
            currentDirectory = newPath;
            Console.WriteLine("Перешли в папку: " + dirName);
        }
        else
        {
            Console.WriteLine("Папка не существует!");
        }
    }

    // 3. Вернуться в родительскую папку
    static void GoToParentDirectory()
    {
        DirectoryInfo parent = Directory.GetParent(currentDirectory);
        if (parent != null)
        {
            currentDirectory = parent.FullName;
            Console.WriteLine("Перешли в родительскую папку");
        }
        else
        {
            Console.WriteLine("Это корневая папка!");
        }
    }

    // 4. Создать новую папку
    static void CreateDirectory()
    {
        Console.Write("Введите имя новой папки: ");
        string dirName = Console.ReadLine();
        string newPath = Path.Combine(currentDirectory, dirName);

        if (!Directory.Exists(newPath))
        {
            Directory.CreateDirectory(newPath);
            Console.WriteLine("Папка создана!");
        }
        else
        {
            Console.WriteLine("Папка уже существует!");
        }
    }

    // 5. Создать новый файл
    static void CreateFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(currentDirectory, fileName);

        if (!File.Exists(filePath))
        {
            Console.Write("Введите текст для файла: ");
            string text = Console.ReadLine();
            
            File.WriteAllText(filePath, text);
            Console.WriteLine("Файл создан и заполнен!");
        }
        else
        {
            Console.WriteLine("Файл уже существует!");
        }
    }

    // 6. Просмотреть содержимое файла
    static void ViewFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(currentDirectory, fileName);

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("Файл не существует!");
        }
    }

    // 7. Удалить файл или папку
    static void DeleteItem()
    {
        Console.Write("Введите имя файла/папки: ");
        string name = Console.ReadLine();
        string path = Path.Combine(currentDirectory, name);

        if (File.Exists(path))
        {
            Console.Write("Удалить файл? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                File.Delete(path);
                Console.WriteLine("Файл удален!");
            }
        }
        else if (Directory.Exists(path))
        {
            Console.Write("Удалить папку? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Directory.Delete(path);
                Console.WriteLine("Папка удалена!");
            }
        }
        else
        {
            Console.WriteLine("Файл/папка не существует!");
        }
    }
}
