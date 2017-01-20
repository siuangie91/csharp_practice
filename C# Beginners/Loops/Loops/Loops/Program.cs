using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //DivisibleByThree();
            //RollingSum();
            //Factorial();
            //GuessRandomNumber();
            FindMax();
        }

        public static void DivisibleByThree()
        {
            int count = 0;

            for (int i = 0; i < 101; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of numbers divisible by 3: " + count);
        }

        public static void RollingSum()
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or OK to exit");
                var input = Console.ReadLine();

                if(input.ToUpper() == "OK" || String.IsNullOrEmpty(input))
                {
                    break;
                } 
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }

            Console.WriteLine("Sum: " + sum);
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter a number:");

            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + "! = " + calcFactorial(input));
        }
        private static int calcFactorial(int i)
        {
            int result;

            if(i == 0 || i == 1)
            {
                result = 1;
            }
            else
            {
                result = i * calcFactorial(i - 1);
            }

            return result;
        }

        public static void GuessRandomNumber()
        {
            Console.WriteLine("Choose a random integer between 1 and 10, inclusive.");

            var randomNumber = new Random();
            var theRandNum = randomNumber.Next(1, 11);
            var numGuesses = 0;
            

            Console.WriteLine("Random number is: " + theRandNum);

            while (true)
            {
                numGuesses++;

                var guess = Convert.ToInt32(Console.ReadLine());

                if (numGuesses == 4)
                {
                    Console.WriteLine("You lost");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess number: " + numGuesses);
                    Console.WriteLine("Your guess: " + guess);

                    if (guess == theRandNum)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                }
            }
        }

        public static void FindMax()
        {
            Console.WriteLine("Enter a series of numbers separated by comma");

            var input = Console.ReadLine().Split(',');

            int max = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(Convert.ToInt32(input[i]) > max)
                {
                    max = Convert.ToInt32(input[i]);
                }
            }

            Console.WriteLine("Max: " + max);
        }
    }
}
