using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class DisplayUniqueNumbers
    {
        private List<int> listOfNumbers = new List<int>();

        public DisplayUniqueNumbers()
        {
            Console.WriteLine("These are the unique numbers: " + ShowUniqueNumbers());
        }

        private string ShowUniqueNumbers()
        {
            getNumbers();

            return getUniqueNumbers(listOfNumbers);
        }

        private void getNumbers()
        {
            while (true)
            {
                Console.WriteLine("Enter a number or type QUIT to exit");

                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input) || input.ToUpper() == "QUIT")
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(input);

                    listOfNumbers.Add(number);
                }
            }
        }

        private string getUniqueNumbers(List<int> theList)
        {
            var arr = new List<int>();

            for (int i = 0; i < theList.Count; i++)
            {
                if (arr.IndexOf(theList[i]) < 0)
                {
                    arr.Add(theList[i]);
                }
            }

            var uniqueNums = String.Join(",", arr);

            return uniqueNums;
        }
    }
}
