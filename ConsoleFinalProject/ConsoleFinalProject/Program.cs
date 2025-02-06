using System;

class Program
{
    static void Main()
    {
        var userData = GetUserData();
        DisplayUserData(userData);
        Console.ReadKey();
    }

    static (string firstName, string lastName, int age, bool hasPet, int petCount, string[] petNames, int favoriteColorsCount, string[] favoriteColors) GetUserData()
    {
        string firstName = ReadStringValue("Введите ваше имя: ", true);
        string lastName = ReadStringValue("Введите вашу фамилию: ", true);
        int age = ReadIntegerValue("Введите ваш возраст: ", true);
        bool hasPet = AskYesNoQuestion("Есть ли у вас питомцы? (да/нет) ");

        int petCount = 0;
        string[] petNames = new string[0];
        if (hasPet)
        {
            petCount = ReadIntegerValue("Сколько у вас питомцев? ", true);
            petNames = GetPetsNames(petCount);
        }

        int favoriteColorsCount = ReadIntegerValue("Сколько у вас любимых цветов? ", true);
        string[] favoriteColors = GetFavoriteColors(favoriteColorsCount);

        return (firstName, lastName, age, hasPet, petCount, petNames, favoriteColorsCount, favoriteColors);
    }

    static string[] GetPetsNames(int count)
    {
        string[] names = new string[count];
        for (int i = 0; i < count; i++)
        {
            names[i] = ReadStringValue($"Введите кличку питомца №{i + 1}: ", true);
        }
        return names;
    }

    static string[] GetFavoriteColors(int count)
    {
        
        string[] colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            colors[i] = ReadStringValue($"Введите ваш любимый цвет №{i + 1}: ", true);
        }
        return colors;
    }

    static string ReadStringValue(string message, bool required)
    {
        while (true)
        {
            Console.Write(message);
            string value = Console.ReadLine()?.Trim();
            if (!required || !string.IsNullOrEmpty(value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Это поле обязательно для заполнения.");
            }
        }
    }

    static int ReadIntegerValue(string message, bool positiveOnly)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value) && (value > 0 || !positiveOnly))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Неверно. Введите целое число больше 0.");
            }
        }
    }

    static bool AskYesNoQuestion(string question)
    {
        while (true)
        {
            Console.Write(question);
            string answer = Console.ReadLine()?.Trim().ToLower();
            if (answer == "да")
            {
                return true;
            }
            else if (answer == "нет")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Ответ должен быть 'да' или 'нет'. Попробуйте снова.");
            }
        }
    }



    static void DisplayUserData((string firstName, string lastName, int age, bool hasPet, int petCount, string[] petNames, int favoriteColorsCount, string[] favoriteColors) data)
    {
        Console.WriteLine("\nДанные пользователя:");
        Console.WriteLine($"Имя: {data.firstName}");
        Console.WriteLine($"Фамилия: {data.lastName}");
        Console.WriteLine($"Возраст: {data.age}");
        Console.WriteLine($"Имеются питомцы: {(data.hasPet ? "Да" : "Нет")}");
        if (data.hasPet)
        {
            Console.WriteLine($"Количество питомцев: {data.petCount}");
            Console.WriteLine("Клички питомцев:");
            foreach (var petName in data.petNames)
            {
                Console.WriteLine($"- {petName}");
            }
        }
        Console.WriteLine($"Количество любимых цветов: {data.favoriteColorsCount}");
        Console.WriteLine("Любимые цвета:");
        foreach (var color in data.favoriteColors)
        {
            Console.WriteLine($"- {color}");
        }


    }
}