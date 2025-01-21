using System;

class MainClass
{
	public static void Main(string[] args)
	{

		//Размерность массива 
		var arr = new int[] { 1, 2, 3, 4 };
		var l = arr.Length;

		//Разные виды инициализации массива
		int[] arr1 = new int[4] { 1, 2, 3, 5 };
		int[] arr2 = new int[] { 1, 2, 3, 5 };
		int[] arr3 = new[] { 1, 2, 3, 5 };
		int[] arr4 = { 1, 2, 3, 5 };
		Console.WriteLine(arr);
		Console.WriteLine(l);
		Console.WriteLine(arr1);
		Console.WriteLine(arr2);
		Console.WriteLine(arr3);
		Console.WriteLine(arr4);
		Console.ReadKey();

	}
}