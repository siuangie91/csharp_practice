using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------
            // Example 1
            // ------------------------
            dynamic name = "Mosh";
            name = 10;

            //there are no exceptions b/c set to dynamic!
            Console.WriteLine(name);

            // ------------------------
            // Example 2
            // ------------------------
            dynamic a = 10;
            dynamic b = 5;
            //var is not dynamic!
            var c = a + b; //because a and b are dynamic, c is also dynamic!

            // ------------------------
            // Example 3
            // ------------------------
            int i = 5;
            dynamic d = i; // at run time, d will be an int
            
            // ------------------------
            // Example 3
            // ------------------------
            int i = 5;
            dynamic d = i;
            long l = d; //at run time, d is int which can be implicitly cast to long
        }
    }
}
