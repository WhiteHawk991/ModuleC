﻿using System;

class MainClass
{
    static string GetFavoriteColor(string username, int age)
    {
        Console.WriteLine($"{username} {age}, \nнапишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine().ToLower();


        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Your color is red, {username}!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Your color is green, {username}!");
                break;

            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Your color is cyan, {username}!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Your color is yellow, {username}!");
                break;
        }

        return color;
    }

    static void Main(string[] args)
    {
        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Моё имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        var favcolors = new string[3]; // Массив для хранения трех любимых цветов
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = GetFavoriteColor(name,age); // Получение любимого цвета и сохранение его в массив
        }

        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }

        Console.ReadKey();
    }
}