using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class TestConsecutive
    {
        private string hyphenedNums;

        public TestConsecutive()
        {
            getNums();
            Console.WriteLine("Numbers are consecutive? " + checkConsecutive(hyphenedNums));
        }

        private void getNums()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");

            hyphenedNums = Console.ReadLine();
        }

        private bool checkConsecutive(string input)
        {
            var arr = input.Split('-');
            var isConsecutive = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(Math.Abs(Convert.ToInt32(arr[i]) - Convert.ToInt32(arr[i + 1])) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            return isConsecutive;
        }
    }
}
