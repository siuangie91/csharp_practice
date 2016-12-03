using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class Program
    {
        //comment to test commit to github
        static void Main(string[] args)
        {
            UseWorkflowEngine();
        }

        static void UseWatch()
        {
            Console.WriteLine("[S] to start; [E] to stop; [R] to reset. [ENTER] to quit.");
            while (true)
            {
                var input = Console.ReadLine().ToUpper();

                if(String.IsNullOrEmpty(input))
                {
                    break;
                }

                switch (input)
                {
                    case "S":
                        Stopwatch.Start();
                        Console.WriteLine("Started: " + Stopwatch.GetStartTime());
                        break;
                    case "E":
                        Stopwatch.Stop();
                        Console.WriteLine("Stopped: " + Stopwatch.GetEndTime());
                        Console.WriteLine("Duration: " + Stopwatch.GetDuration().ToString("c"));
                        break;
                    case "R":
                        Stopwatch.Reset();
                        Console.WriteLine("Stopwatch resetted.");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command");
                        break;
                }
            }
        }

        static void UsePost()
        {
            var post = new Post("Post Title", "Post description is that this is the description.");

            Console.WriteLine("Init vote value: " + post.ShowVoteValue());

            for (var i = 0; i < post.Description.Length; i++)
            {
                post.UpVote();
            }

            Console.WriteLine("Upvoted vote value: " + post.ShowVoteValue());

            for (var i = post.Title.Length; i > 0; i--)
            {
                post.DownVote();
            }

            Console.WriteLine("Downvoted vote value: " + post.ShowVoteValue());
        }

        static void UseStack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Popped: " + stack.Pop());
            stack.showStackList();
            Console.WriteLine("Popped: " + stack.Pop());
            stack.showStackList();
            Console.WriteLine("Popped: " + stack.Pop());
            stack.showStackList();

            //stack.Clear();
            //Console.WriteLine("Stack cleared.");
            //stack.showStackList();
        }

        static void UseDbConnection()
        {
            //var sqlConnection = new SqlConnection("Sql Connection");
            //var dbCommand = new DbCommand(sqlConnection, "Database instruction string");

            var oracleConnection = new OracleConnection("Oracle Connection");
            var dbCommand = new DbCommand(oracleConnection, "Database instruction string");

            dbCommand.Execute();
        }

        static void UseWorkflowEngine()
        {
            var workflow = new Workflow();
            workflow.AddActivity(new CopyActivity());
            workflow.AddActivity(new PasteActivity());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
