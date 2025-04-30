using System;
using System.Collections.Generic;

    public class PromptGenerator()
    {
        public List<string> _prompts = new List<string>
        {
            "What was the best part of your day?",
            "Did you see any cool dogs?",
            "Did you acheive any goals today?",
            "What are you grateful for today?",
            "If you had all the money in the world, what would you do?",
            "Are you proud of what you've accomplished today?",
            "What is the current problem you are facing?"
        };

        public Random _random = new Random();

        public string GetRandomPrompt()
        {   
            int index = _random.Next(_prompts.Count);
            return _prompts[index];   
        }
    }