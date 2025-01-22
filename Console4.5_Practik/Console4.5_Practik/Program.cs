using System;


namespace Console4._5_Practik
{
    class Program
    {
        static void Main(string[] args)
        {

        (string name,string first_name,string login, int LoginLength, bool Pets, double age, string[] favcolors) User;

            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.first_name = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.login = Console.ReadLine();
            User.LoginLength = User.login.Length;
            Console.WriteLine(User.LoginLength);
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                User.Pets = true; 
            }
            else { User.Pets = false;
            }
            Console.WriteLine("Введите возраст пользователя");
            User.age = double.Parse(Console.ReadLine());
            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < User.favcolors.Length; i++)
            {

            }
            Console.ReadKey();



        }
    }
}
