using System;
using System.Net.Http.Headers;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSec;
    private List<Comment> _comments = new List<Comment>();

    //get set section
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthSec = length;
    }

    public string GetVideoTitle()
    {
        return _title;
    }

    public string GetVideoAuthor()
    {
        return _author;
    }

    public int GetVideoLength()
    {
        return _lengthSec;
    }
    // get set end
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentNumber()
    {
        return _comments.Count();
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}