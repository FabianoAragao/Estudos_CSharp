using System;
using System.Collections.Generic;
using PostsEComments.Entidades;

namespace PostsEComments
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's aewsome!");

            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Taveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12
                );

            p1.AddComentario(c1);
            p1.AddComentario(c2);

            //-----------------------------------------

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5
                );

            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
