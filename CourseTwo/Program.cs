using System;
using System.Globalization;
using C_.Entities;

namespace Course
{
    class Course
    {


        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New ZeaLand ",
                "I'M going to visit this wonderful contry",
                12);


            post.AddComment(c1);
            post.AddComment(c2);

            Comment d1 = new Comment("Good Night");
            Comment d2 = new Comment("May the Force be with you");

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good Night Guys",
                "See you tomorrow ",
                5
                );

            post2.AddComment(d1);
            post2.AddComment(d2);

            Console.WriteLine(post);
            Console.WriteLine(post2);
        }


        }

    }




