using System;

class MainClass
{
    static void Main(string[] args)
{
     Console.Write("Enter your age: ");
     int age;   
     bool iscorrect = int.TryParse(Console.ReadLine(), out age);
     Console.WriteLine("Your age is {0} ", age);
     Console.ReadKey();
}

}