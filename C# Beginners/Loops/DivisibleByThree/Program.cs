using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Loops.MaxInSeries();
        }
    }

    public class Loops
    {
        public static void DivisibleByThree()
        {
            var count = 0;
            for (int i = 0; i < 100; i++)
            {
                if(i % 3==0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are " + count + " numbers that are divisible by 3 between 0 and 100");
        }

        public static void SumOfEnteredNumbers()
        {
            var total = 0;
            
            while(true)
            {
                Console.WriteLine("Enter a number or OK to exit");

                var input = Console.ReadLine();

                if(input.ToUpper() == "OK") { break; }

                total += Convert.ToInt32(input);

            }

            Console.WriteLine("The sum of your inputs is " + total);
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter an integer:");
            var input = Convert.ToInt32(Console.ReadLine());

            var result = 1;

            if(input == 1 || input == 0)
            {
                Console.WriteLine(input + "! = 1");
            }
            else
            {
                for (var i = input; i > 0; i--)
                {
                    result *= i;
                }

                Console.WriteLine(input + "! = " + result);
            }
            
        }

        public static void GuessTheNum()
        {
            var randomNum = new Random();
            int secret = randomNum.Next(1, 10);
            Console.WriteLine("The secret number is " + secret);

            var numGuesses = 1;

            while(numGuesses <= 4)
            {
                Console.WriteLine("Guess the random number between 1 and 10");
                var input = Convert.ToInt32(Console.ReadLine());

                if(input == secret)
                {
                    Console.WriteLine("Yes! The secret number is indeed " + input + "!");
                    break;
                }

                Console.WriteLine("Nope. Guess again. You have " + (4 - numGuesses) + " guesses left.");

                numGuesses++;
            }

            Console.WriteLine("The secret number is " + secret);
        }

        public static void MaxInSeries()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma");

            var input = Console.ReadLine().Split(',');

            var max = 0;

            foreach(var str in input)
            {
                var num = Convert.ToInt32(str);

                if(num > max) { max = num; }
            }

            Console.WriteLine("Max is " + max);
        }
    }
}
