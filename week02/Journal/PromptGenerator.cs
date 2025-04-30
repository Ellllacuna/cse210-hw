using System;
using System.Collections.Generic;

    public class PromptGenerator()
    {
        public List<string> _prompts = new List<string>
        {
            "What was the best part of your day?",
            "Did you see any cool dogs?",
            "Did you acheive any goals today?"
        };

        public Random _random = new Random();

        public string GetRandomPrompt()
        {   
            int index = _random.Next(_prompts.Count);
            return _prompts[index];   
        }
    }