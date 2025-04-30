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

                _entries.Add(entry);   
            }

            Console.WriteLine($"Journal loaded from {fileName}");
        }
    }