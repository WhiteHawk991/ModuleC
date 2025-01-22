using System;

class MainClass
{
	public static void Main(string[] args)
	{

		int k = 0;

		while (true)
		{
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
			Console.WriteLine(k);


			var text = Console.ReadLine();
			switch (text)
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is green!");
					break;

				case "cyan":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is cyan!");
					break;
				default:
					continue;
			}

			if (text == "stop")
			{
				Console.WriteLine("Цикл остановлен");
				break;
			}


			k++;
		}
		Console.ReadKey();

	}
}