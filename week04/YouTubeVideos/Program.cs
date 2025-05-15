using System;
using System.ComponentModel.Design;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Candle Making for Idiots", "Idiot", 400);
        video1.AddComment(new Comment("Dad", "Get a real job"));
        video1.AddComment(new Comment("Brain man", "Yummu Yummy candles"));
        video1.AddComment(new Comment("Elizabth", "I made a candle once and this guy came up and ate it"));
        videos.Add(video1);

        Video video2 = new Video("I found dirt in my bathroom", "megatron", 1600000072);
        video2.AddComment(new Comment("transformer", "pack it up pack it in let us begin"));
        video2.AddComment(new Comment("Brain man", "Yummu Yummy dirt in the bathroom"));
        video2.AddComment(new Comment("Todd", "I love shovels"));
        videos.Add(video2);

        Video video3 = new Video("CORNEA EXPLOSION", "eye doctor", 20);
        video3.AddComment(new Comment("Norm", "Love this guy's work. Been following him for years"));
        video3.AddComment(new Comment("Brain man", "Yummu Yummy eye ball juice"));
        video3.AddComment(new Comment("Elizabth", "This guy scares me"));
        video3.AddComment(new Comment("Robert", "Ditto"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetVideoTitle()}");
            Console.WriteLine($"Author: {video.GetVideoAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentNumber()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommenterText()}");
            }
            Console.WriteLine();
        }
    }
}