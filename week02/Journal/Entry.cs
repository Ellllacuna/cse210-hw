using System;

    public class Entry()
    {
        public string _date;
        public string _promptText;
        public string _entryText;
        //extra
        public string _mood;
        public string _location;
        //end extra


        public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\nMood: {_mood}\nLocation: {_location}");
        }

        public string GetDisplayText()
        {
            //return ($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
            return ($"{_date}|{_promptText}|{_entryText}|{_mood}|{_location}");
        }
    }