using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int Number = -1;
        
        // adding the number to the list
        List<int> numbers = new List<int>();
                Console.WriteLine("Type a number and then enter for it to be added to the list, when done, type 0 to end the list");
        while (Number != 0)
        {
        // Providing the number
        Console.WriteLine("Enter Number: ");
        Number = int.Parse(Console.ReadLine());
        if (Number != 0)
        {
        numbers.Add(Number);
        }
        //computations
        }
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Thanks for providing the list of numbers.");
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The Average is {average}");
        int maximum = numbers.Max();
        Console.WriteLine($"The largest number is {maximum}");
        var positiveNumbers = numbers.Where(n => n > 0);
        if (positiveNumbers.Any())
        {
        int smallest_Positive = positiveNumbers.Min();
        Console.WriteLine($"The smallest positive number is: {smallest_Positive}");
        }
         else
       {
        Console.WriteLine("There are no positive numbers in the list to evaluate.");
       }
        }
        
 }