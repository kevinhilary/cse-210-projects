using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics", "Tech Guru", 600);
        Video video2 = new Video("OOP Explained", "Code Academy", 900);
        Video video3 = new Video("Abstraction in C#", "Dev Simplified", 750);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Very helpful video!"));
        video1.AddComment(new Comment("Brian", "Clear explanation."));
        video1.AddComment(new Comment("Clara", "Loved the examples."));

        // Add comments to video 2
        video2.AddComment(new Comment("Daniel", "This finally makes sense."));
        video2.AddComment(new Comment("Eva", "Great breakdown of concepts."));
        video2.AddComment(new Comment("Frank", "Nice and simple."));

        // Add comments to video 3
        video3.AddComment(new Comment("Grace", "Exactly what I needed."));
        video3.AddComment(new Comment("Henry", "Thanks for this."));
        video3.AddComment(new Comment("Irene", "Short and precise."));

        // Put videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        // Display video details
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLength());
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine(); // blank line between videos
        }
    }
}