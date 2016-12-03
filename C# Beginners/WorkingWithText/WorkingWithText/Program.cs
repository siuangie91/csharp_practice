using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            CountVowels();
        }

        public static void TestConsecutive()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();

            var splitInput = input.Split('-');

            bool isConsecutive = false;

            for(var i = 0; i < splitInput.Length - 1; i++)
            {
                if(Convert.ToInt32(splitInput[i]) == Convert.ToInt32(splitInput[i+1]) - 1)
                {
                    isConsecutive = true;
                }
                else if (Convert.ToInt32(splitInput[i]) == Convert.ToInt32(splitInput[i + 1]) + 1)
                {
                    isConsecutive = true;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }
            }

            if(isConsecutive)
            {
                Console.WriteLine("Consecutive");
            } else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

        public static void TestForDuplicates()
        {
            while(true)
            {
                Console.WriteLine("Enter a few numbers seprated by a hyphen");

                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    var splitInput = input.Split('-');

                    var uniqueNumsList = new List<int>();

                    var hasDuplicate = false;

                    for(var i = 0; i < splitInput.Length; i++)
                    {
                        if(uniqueNumsList.IndexOf(Convert.ToInt32(splitInput[i])) != -1)
                        {
                            hasDuplicate = true;
                            break;
                        }

                        uniqueNumsList.Add(Convert.ToInt32(splitInput[i]));

                        hasDuplicate = false;
                    }

                    if(hasDuplicate)
                    {
                        Console.WriteLine("Duplicate");
                    } else
                    {
                        Console.WriteLine("No duplicates");
                    }

                    break;
                }
            }
        }

        public static void ValidateTime()
        {
            Console.WriteLine("Enter a time value in the 24 hour format");

            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time!");
            } else
            {
                var time = input.Split(':');

                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);

                if ((hour >= 0 && hour < 24) && (minute >= 0 && minute < 60))
                {
                    Console.WriteLine("Valid Time!");
                }                
                else
                {
                    Console.WriteLine("Invalid Time!");
                }
            }
            
        }

        public static void MakePascalCase()
        {
            Console.WriteLine("Enter a few words separated by a space");

            var input = Console.ReadLine().Split(' ');

            var pascalString = "";

            foreach(var word in input)
            {
                var convertedCurrent = Convert.ToString(word[0]).ToUpper() + word.Substring(1).ToLower();

                pascalString += convertedCurrent;
            }

            Console.WriteLine(pascalString);
        }

        public static void CountVowels()
        {
            Console.WriteLine("Enter an English word");

            var input = Console.ReadLine();

            var numVowels = 0;

            for(var i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        numVowels++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(numVowels);
        }
    }
}
