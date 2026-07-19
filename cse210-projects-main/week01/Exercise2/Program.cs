using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which grade percentage do you have in CSE210 W04 assignment?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";
        if (number >= 90)
        letter = "Grade: A";
        else if (number >= 80)
        letter = "Grade: B";
        else if (number >= 70)
        letter = "Grade: C";
        else if (number >= 60)
        letter = "Grade: D";
        else
        letter = "Grade: F";
        
        if (number%10 >= 7 && letter != "Grade: F" && letter != "Grade: A")
        letter += "+";
        else if (number%10 < 3 && letter != "Grade: F")
        letter += "-";
        Console.WriteLine(letter);

        if (number >= 70)
        Console.WriteLine("NB: Congratulations! You passed the course and you are capable of continuing to the next course.");
        else
        Console.WriteLine("NB: The end isn`t determined by these results. Trying once again, There is another chance ever in life and you will make it.");
    }
}