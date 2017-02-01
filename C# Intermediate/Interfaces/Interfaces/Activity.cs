using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ExecutableActivity : IExecutable
    {
        public string Name { get; set; }

        public ExecutableActivity(string name)
        {
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine("Running " + Name);
        }
    }
}
