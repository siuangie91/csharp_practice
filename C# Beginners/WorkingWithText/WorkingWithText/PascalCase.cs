using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class PascalCase
    {
        public PascalCase()
        {
            var theString = GetWords();
            var pascalCased = MakePascalCase(theString);

            Console.WriteLine(pascalCased);
        }

        private string GetWords()
        {
            Console.WriteLine("enter a few words separated by a space.");
            var input = Console.ReadLine();

            return input;
        }

        private string MakePascalCase(string input)
        {
            var namesList = input.Split(' ');
            string pascalCased = null;

            for (int i = 0; i < namesList.Length; i++)
            {
                for (int j = 0; j < namesList[i].Length; j++)
                {
                    if (j == 0)
                    {
                        pascalCased += namesList[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        pascalCased += namesList[i][j].ToString().ToLower();
                    }
                }
            }

            return pascalCased;
        }
    }
}
