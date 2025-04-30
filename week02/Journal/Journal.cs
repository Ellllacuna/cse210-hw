using System;
using System.IO;

    public class Journal()
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    string newEntry = entry.GetDisplayText();
                    outputFile.WriteLine(newEntry);
                    
                }
            }
        
            Console.WriteLine($"Journal saved to {filename}.");
        }

        public void LoadFromFile(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string [] parts = line.Split('|');

                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                //extra
                entry._mood = parts[3];
                entry._location = parts[4];
                //end extra

                _entries.Add(entry);   
            }

            Console.WriteLine($"Journal loaded from {fileName}");
        }

        public void Searching(string keyword)
        {
            bool found = false;
            Console.WriteLine("\nresults:");

            foreach (Entry entry in _entries)
            {
                if ((entry._mood != null && entry._mood.ToLower().Contains(keyword.ToLower())) ||
                (entry._location != null && entry._location.ToLower().Contains(keyword.ToLower())) ||
                (entry._entryText!= null && entry._entryText.ToLower().Contains(keyword.ToLower())))
                {
                    Console.WriteLine();
                    entry.Display();
                    found = true;
                }

            }

            if (!found)
            {
                Console.WriteLine("No entries match that keyword.");
            }

        }
    }