using SocialNetwork.Entities;
using System;
using System.Collections.Generic;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post()
            {
                Moment = new DateTime(2018, 06, 21, 13, 05, 44),
                Likes = 12,
                Title = "Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country!",
                Comments = new List<Comment>
                {
                    new Comment("Have a nice trip"),
                    new Comment("Wow that's awesome!")
                }

            };

            Console.WriteLine(post1);
            Console.WriteLine();

            Post post2 = new Post()
            {
                Moment = new DateTime(2018, 07, 28, 23, 14, 19),
                Likes = 5,
                Title = "Good night guys",
                Content = "See you tomorrow",
            };

            post2.AddComment(new Comment("Good night"));
            post2.AddComment(new Comment("May the Force be with you"));

            Console.WriteLine(post2);
        }
    }
}
