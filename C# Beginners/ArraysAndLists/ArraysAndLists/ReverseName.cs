using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class ReverseName
    {
        private string name;

        public ReverseName()
        {
            Console.WriteLine(ReverseIt(GetName()));
        }

        private string GetName()
        {
            Console.WriteLine("Enter a name:");
            var input = Console.ReadLine();
            return input;
        }

        private string ReverseIt(string name)
        {
            var nameArray = new string[name.Length];

            for (int i = name.Length - 1; i >= 0; i--)
            {
                nameArray[name.Length - 1 - i] = Char.ToString(name[i]);
            }

            var result = String.Join("", nameArray);

            return result;
        }
    }
}
