using System;

/*
==================================================================================
CREATIVITY AND EXCEEDING REQUIREMENTS REPORT:
1. Integrated System.Text.Json format for saving and loading. Standard text and CSV
   files break easily if users type commas, quotes, or line breaks inside their entry.
   By using JSON serialization, the program safely saves any complex text characters.
2. Formatted user interface with clean visual dividers and clear input menus.
==================================================================================
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Retrieve a random prompt
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                // Build a new Entry object
                
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                // Add to the journal using encapsulation method
                
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("\nThank you for using the Journal. Goodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please choose a number from 1 to 5.");
            }
        }
    }
}