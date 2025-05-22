using System;

public class MathAssignment : Assignments
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() : base()
    {

    }
    public MathAssignment(string studentName, string topic, string textbookSelection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSelection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\n{_textbookSection} {_problems}";
    }
}