using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class SortUniqueNumbers
    {
        private List<int> numbers = new List<int>();

        public SortUniqueNumbers()
        {
            Console.WriteLine(getNumbers());
        }

        private string getNumbers()
        {
            Console.WriteLine("Enter a unique number");

            while(numbers.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (numbers.IndexOf(input) != -1)
                {
                    Console.WriteLine("You've entered this number already");
                    continue;
                }

                numbers.Add(input);
            }

            return sort(numbers);
        }

        private string sort(List<int> numList)
        {
            numList.Sort();

            return String.Join(",", numList);
        }
    }
}
