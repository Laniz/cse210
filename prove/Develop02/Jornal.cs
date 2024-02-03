using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void WriteNewEntry(string prompt)
    {
        Console.Write("");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            Date = DateTime.Now,
            Prompt = prompt,
            Response = response
        };

        entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}\nResponse: {entry.Response}\n");
            }
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(',');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry loadedEntry = new Entry
                    {
                        Date = date,
                        Prompt = prompt,
                        Response = response
                    };

                    entries.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found. Please make sure the file exists.");
        }
    }
}
