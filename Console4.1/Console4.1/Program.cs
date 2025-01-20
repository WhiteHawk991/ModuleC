using System;

class MainClass
{
	public static void Main(string[] args)
	{

			var a = 6;
			var b = 7;

			var c = a != b ? a + b : b;

			Console.WriteLine(c);

			Console.ReadKey();
	}
}