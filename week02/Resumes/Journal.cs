using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Used to cleanly fulfill the creative stretch goals

public class Journal
{
    // List to hold the entries
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all the entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is currently empty.");
            return;
        }

        Console.WriteLine("\n=== JOURNAL ENTRIES ===");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the journal to a file using structured JSON
    public void SaveToFile(string file)
    {
        try
        {
            // Serialize options to make the generated file neat and easy to read
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(_entries, options);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(jsonString);
            }
            Console.WriteLine($"\nJournal successfully saved to {file}!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    
    public void LoadFromFile(string file)
    {
        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("\nFile not found. Please verify the file name and try again.");
                return;
            }

            string jsonString = File.ReadAllText(file);
    
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine($"\nJournal successfully loaded from {file}!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
    }
}