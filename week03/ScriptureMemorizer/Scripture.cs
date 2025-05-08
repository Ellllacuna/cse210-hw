using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }   

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        List<Word> visibleWords = new List<Word>();
        foreach (Word i in _words)
        {
            if (!i.IsHidden())
            {
                visibleWords.Add(i);
            }
        }

        int count = numberToHide;
        if (visibleWords.Count < numberToHide)
        {
            count = visibleWords.Count;
        }
        //i = loop counter. does as many loops as the count
        //says to, default three. i++ increments then number of loops each time so that it stops when it reaches 3 or whatever count is
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

        
    } 

    public string GetDisplayText()
        {
            string reference = _reference.GetDisplayText() + "\n";

            foreach (Word word in _words)
            {
              reference += word.GetDisplayText() + " ";  
            }

            return reference;
        }
    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}