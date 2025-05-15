using System;
using System.Runtime.InteropServices;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetCommenterName()
    {
        return _name;
    }

    public string GetCommenterText()
    {
        return _text;
    }
}