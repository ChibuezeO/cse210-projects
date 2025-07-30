using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "TechGuru", 600);
        video1.AddComment(new Comment("Jacob", "Great tutorial!"));
        video1.AddComment(new Comment("Moroni", "Very clear explanation."));
        video1.AddComment(new Comment("Charlie", "Thank you!"));
        videos.Add(video1);

        Video video2 = new Video("ASP.NET Core Basics", "WebMaster", 1200);
        video2.AddComment(new Comment("Dave", "Nice examples!"));
        video2.AddComment(new Comment("Eze", "Please make more ASP.NET videos."));
        video2.AddComment(new Comment("Okoro", "I enjoyed it."));
        video2.AddComment(new Comment("Grace", "very helpful!"));
        videos.Add(video2);

        Video video3 = new Video("Entity Framework Tutorial", "CodeNinja", 1800);
        video3.AddComment(new Comment("Hyacinth", "Amazing content!"));
        video3.AddComment(new Comment("Chibueze", "Thanks for the tips."));
        video3.AddComment(new Comment("Nephi", "I learned so much!"));
        videos.Add(video3);

        Video video4 = new Video("Blazor for Beginners", "DevPro", 900);
        video4.AddComment(new Comment("Kate", "Really useful!"));
        video4.AddComment(new Comment("okafor", "Clear and concise."));
        video4.AddComment(new Comment("Gozie", "This was helpful"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video: {video.Title()}");
            Console.WriteLine($"Author: {video.Author()}");
            Console.WriteLine($"Length: {video.Length()} seconds");
            Console.WriteLine($"Number of Comments: {video.CountComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.CommentsList())
            {
                Console.WriteLine($"- {comment.CommenterName()}: {comment.CommentText()}");
            }
            Console.WriteLine();
        }
    }
}