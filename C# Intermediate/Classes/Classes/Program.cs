using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //runStopwatch();
            //runPost("The Title", "The description of this post is that it is a description which was required in the description of the post.");

        }

        static void runStopwatch()
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("[START,STOP,CALC]");
                var input = Console.ReadLine().ToUpper();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Not a valid command.");
                    continue;
                }
                else if (input == "START")
                {
                    stopwatch.Start();
                    continue;
                }
                else if (input == "STOP")
                {
                    stopwatch.Stop();
                    continue;
                }
                else if (input == "CALC")
                {
                    var duration = stopwatch.CalcDuration();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Duration: " + duration);
                    Console.WriteLine("---------------------------");
                    stopwatch.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Not a valid command.");
                    continue;
                }
            }
        }

        static void runPost(string title, string description)
        {
            var post = new Post
            {
                Title = title,
                Description = description
            };

            post.DisplayPostInfo();

            foreach (var letter in post.Description)
            {
                post.UpVote();
            }

            post.DisplayPostInfo();

            foreach (var letter in post.Title)
            {
                post.DownVote();
                post.DownVote();
            }

            post.DisplayPostInfo();
        }
    }
}
