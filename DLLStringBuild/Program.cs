using System;
using DLLStringBuild.Entities;
using DLLStringBuild.Entities;

namespace DLLStringBuild {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Traveling to New Zealand");
            Post post1 = new Post() {
                Date = DateTime.Parse("21/06/2018"),
                Title = "Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country",
                Likes = 12
            };
            Comment comment1 = new Comment("Have a nice trip!");
            post1.addComment(comment1);
            Comment comment2 = new Comment("Wow! That's awensome");
            post1.addComment(comment2);

            Console.WriteLine(post1);
        }
    }
}
