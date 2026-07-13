using System;

class Program
{
    static void Main(string[] args)
    {
Console.WriteLine("You are welcome to the crudetial input program.");

Console.WriteLine("What is your first name? ");
String firstname = Console.ReadLine();

Console.WriteLine("What is your last name? ");
String lastname = Console.ReadLine();

Console.Write($"Your name is {lastname}, {firstname} {lastname}.");
    }
}