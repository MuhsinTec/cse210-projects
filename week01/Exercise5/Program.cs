using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeClause();
        string userName = UserInfo();
        int favNumber = PromptUserNumber();
        int calculatedSquare= SquareNumbers(favNumber);
        Combined(userName, calculatedSquare);
    }
    static void WelcomeClause() 
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string UserInfo() 
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber() 
        {
            Console.WriteLine("Please insert your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        } 
        static int SquareNumbers(int favNumber)
        {
            int square = favNumber * favNumber;
            return square;
        } 
        static void Combined(string name, int square)
        {
        Console.WriteLine($"{UserInfo}, the square of your number is {square}");
        }
}