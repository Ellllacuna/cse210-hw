using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        bool Quit = false;
        bool Done = false;
        //enter first video
        do
        {
            Console.WriteLine("Enter the video information.");
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Length (in seconds): ");
            string lengthInput = Console.ReadLine();
            int length = int.Parse(lengthInput);

            Video video1 = new Video(title, author, length);

            Console.WriteLine("\nComment Section. Please enter the comment information.");
            Done = false;
            do
            {
                Console.Write("Comment Author: ");
                string commentAuthor = Console.ReadLine();

                Console.Write("Comment Text: ");
                string commentText = Console.ReadLine();

                video1.AddComment(new Comment(commentAuthor, commentText));

                Console.Write("\nAdd another comment? (Y/N) ");
                string doneinput = Console.ReadLine();
                if (doneinput.ToLower() == "n" || doneinput == "no")
                {
                    Done = true;
                }
            } while (!Done);

            videos.Add(video1);

            Console.Write("\nAdd another video? (Y/N) ");
            string quitInput = Console.ReadLine();
            if (quitInput == "n" || quitInput == "no")
            {
                Quit = true;
            }
            Console.WriteLine();
        } while (Quit == false);

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