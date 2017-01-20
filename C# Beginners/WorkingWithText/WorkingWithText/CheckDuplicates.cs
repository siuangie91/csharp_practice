using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class CheckDuplicates
    {
        private string theNums;

        public CheckDuplicates()
        {
            getNums();
            Console.WriteLine(IsDuplicate(checkForDupes(theNums)));
        }

        private void getNums()
        {
            while (true)
            {
                Console.WriteLine("enter a few numbers separated by a hyphen.");
                var input = Console.ReadLine();

                if(String.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    theNums = input;
                    break;
                }
            }
        }

        private bool checkForDupes(string numbers)
        {
            var arr = theNums.Split('-');
            var uniqueArr = new List<int>();
            bool hasDupes;

            for (int i = 0; i < arr.Length; i++)
            {
                if(uniqueArr.IndexOf(Convert.ToInt32(arr[i])) == -1)
                {
                    uniqueArr.Add(Convert.ToInt32(arr[i]));
                }
            }

            if(uniqueArr.Count == arr.Length)
            {
                hasDupes = false;
            }
            else
            {
                hasDupes = true;
            }

            return hasDupes;
        }

        private string IsDuplicate(bool test)
        {
            if (test == false)
            {
                return "No Duplicate";
            }
            else
            {
                return "Duplicate";
            }
        }
    }
}
