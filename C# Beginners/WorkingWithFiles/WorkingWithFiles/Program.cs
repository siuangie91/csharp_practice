using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResult(Convert.ToString(CountNumWords()));
            DisplayResult(LongestWordInFile());
        }

        public static void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }

        public static int CountNumWords()
        {
            var text = File.ReadAllText(@"C:\Users\asiu\Desktop\fourwords.txt");
            var array = text.Split(' ');

            var numWords = 0;

            foreach (var word in array)
            {
                numWords++;
            }

            return numWords;
        }

        public static string LongestWordInFile()
        {
            var file = File.ReadAllText(@"C:\Users\asiu\Desktop\fourwords.txt");
            var array = file.Split(' ');

            var greatestLength = 0;
            string longestWord = null;

            foreach (var word in array)
            {
                if (word.Length > greatestLength)
                {
                    greatestLength = word.Length;
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
