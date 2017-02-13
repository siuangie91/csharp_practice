using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //by convention extension classes must be static
    //if they are in a separate namespace, must reference that namespace
    //name of class is the class you are extending + "Extensions"
    public static class StringExtensions
    {
        //the extension method's 1st arg is the class you are extending
        //the args after that are whatever you need to pass in
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be >= 0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
