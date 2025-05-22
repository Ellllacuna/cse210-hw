using System;

public class WritingAssignment : Assignments
{
    private string _title;

    public WritingAssignment() : base()
    {

    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title} by {_studentName}";
    }
}