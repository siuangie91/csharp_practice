using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class ValidateTime
    {
        public ValidateTime()
        {
            var theInput = getTime();
            var isItValid = checkValid(theInput);

            if(isItValid)
            {
                Console.WriteLine("Valid time!");
            }
            else
            {
                Console.WriteLine("Invalid time!");
            }
        }

        private string getTime()
        {
            Console.WriteLine("Enter a time value in the 24 hour format");

            var input = Console.ReadLine();

            return input;

        }

        private bool checkValid(string time)
        {
            bool isValid;

            if (String.IsNullOrWhiteSpace(time))
            {
                isValid = false;
            }
            else
            {
                var theTime = time.Split(':');
                var hour = Convert.ToInt32(theTime[0]);
                var minute = Convert.ToInt32(theTime[1]);

                if((hour >= 0 && hour < 24) && (minute >= 0 && minute < 60))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
