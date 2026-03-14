using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }


        public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

        public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._txPrompt = parts[1];
            newEntry._txEntry = parts[2];

            _entries.Add(newEntry);
        }
    }

        public void SaveFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._txPrompt}|{entry._txEntry}");
            }
        }
    }








}