using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class SmallestInList
    {
        private List<int> theList = new List<int>();

        public SmallestInList()
        {
            Console.WriteLine("The 3 smallest numbers are: " + DisplaySmallest());
        }

        private string DisplaySmallest()
        {
            GetNumbers();

            theList.Sort();
            return String.Join(",", theList[0], theList[1], theList[2]);
        }

        private void GetNumbers()
        {
            while (theList.Count < 5)
            {
                Console.WriteLine("Invalid List");
                Console.WriteLine("Please enter at least 5 comma separated numbers");
                var input = Console.ReadLine();

                var nums = input.Split(',');

                foreach (var item in nums)
                {
                    var num = Convert.ToInt32(item);

                    theList.Add(num);
                }
            }
        }
    }
}
