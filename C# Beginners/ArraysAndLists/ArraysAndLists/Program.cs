using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayLists.DisplaySmallestThree();
        }

        public class ArrayLists
        {
            public static void FacebookLikes()
            {
                var names = new List<string>();

                while(true)
                {
                    Console.WriteLine("Enter a name or hit ENTER to quit:");
                    var input = Console.ReadLine();
                    if(String.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    names.Add(input);
                }

                var countOfNames = names.Count;

                Console.WriteLine(countOfNames);

                switch (countOfNames)
                {
                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("{0} likes your post", names[0]);
                        break;
                    case 2:
                        Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                        break;
                    default:
                        Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], (countOfNames - 2));
                        break;
                }
            }

            public static void ReverseName()
            {
                Console.WriteLine("Enter a name");
                var name = Console.ReadLine();

                char[] nameInReverse = new char[name.Length];

                for(var i = name.Length; i > 0; i--)
                {
                    //Console.WriteLine("index {0}: {1}", i-1, name[i-1]);
                    nameInReverse[nameInReverse.Length - i] = name[i - 1];
                }

                var reversed = new string(nameInReverse);
                Console.WriteLine("Reversed name: {0}", reversed);
            }

            public static void FiveUniqueNums()
            {
                var numbersList = new List<int>();

                while (numbersList.Count < 5)
                {
                    Console.WriteLine("Enter a unique number");
                    var input = Convert.ToInt32(Console.ReadLine());

                    if(numbersList.IndexOf(input) != -1)
                    {
                        Console.WriteLine("You've entered this number already");
                        continue;
                    }

                    numbersList.Add(input);
                }

                numbersList.Sort();

                Console.WriteLine("The sorted list is:");
                foreach(var num in numbersList)
                {
                    Console.WriteLine(num);
                }
            }

            public static void DisplayUniqueNums()
            {
                var list = new List<int>();

                while (true)
                {
                    Console.WriteLine("Enter a number or type QUIT to exit");
                    var input = Console.ReadLine();

                    if(input.ToUpper() == "QUIT")
                    {
                        break;
                    }

                    var parsedInput = Convert.ToInt32(input);

                    if(list.IndexOf(parsedInput) == -1)
                    {
                        list.Add(parsedInput);
                    } else
                    {
                        continue;
                    }

                }

                foreach(var num in list)
                {
                    Console.WriteLine(num);
                }
            }

            public static void DisplaySmallestThree()
            {
                var theList = new List<int>();

                while (true)
                {
                    Console.WriteLine("Enter a list of comma separated numbers");

                    var input = Console.ReadLine().Split(',');

                    if (input.Length < 5)
                    {
                        Console.WriteLine("Invalid List. Please try again.");
                        continue;
                    }
                    else
                    {
                        foreach (var num in input)
                        {
                            theList.Add(Convert.ToInt32(num));
                        }
                        break;
                    }
                    
                }

                theList.Sort();

                for(var i = 0; i < 3; i++)
                {
                    Console.WriteLine(theList[i]);
                }
            }
        }
    }
}
