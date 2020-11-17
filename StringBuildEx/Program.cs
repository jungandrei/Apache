using System;
using System.Security.Claims;
using StringBuildEx.Entities;

namespace StringBuildEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 INSTANCIA
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            //Populando o construtor do Post
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            //2 INSTANCIA
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            //Populando o construtor do Post
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night",
                "See you tomorrow",
                5);

            p1.AddComment(c3);
            p1.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
