using System;

class MainClass
{
	public static void Main(string[] args)
	{

		string MyName = "Стас";
		byte MyAge = 33;
		bool HaveIApet = true;
		double MyShoeSize = 43.5;

		Console.WriteLine("Меня зовут " + MyName);
		Console.WriteLine("Мне " + MyAge);
		Console.WriteLine("У меня есть питомец " + HaveIApet);
		Console.WriteLine("Мой размер ноги " + MyShoeSize);
		Console.ReadKey();	

	}
}