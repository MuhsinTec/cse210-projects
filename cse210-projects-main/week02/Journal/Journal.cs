public void SaveToFile(string file)
{
    try
    {
        // Use StreamWriter to write plain text to the file
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Write each entry as a single line using a pipe '|' to separate fields
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
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

        // Clear the current list so you don't stack duplicates when loading a file
        _entries.Clear();

        // Read all lines from the text file
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // Split the line back into parts using the '|' character
            string[] parts = line.Split('|');

            // Make sure the line has exactly the 3 expected parts before creating the Entry
            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];

                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine($"\nJournal successfully loaded from {file}!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading from file: {ex.Message}");
    }
}