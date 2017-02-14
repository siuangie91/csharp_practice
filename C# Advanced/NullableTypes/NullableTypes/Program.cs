using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            //returns value if obj has been inited or returns default value if null
            Console.WriteLine("date.GetValueOrDefault() -- " + date.GetValueOrDefault());

            //returns true if obj has a value, false is null
            Console.WriteLine("date.HasValue -- " + date.HasValue);

            //returns the value or exception if obj has no value
            //Console.WriteLine("date.Value -- " + date.Value);


            DateTime? date1 = new DateTime(2014, 1, 1);
            //this won't compile! cannot set a nullable DateTime into a DateTime!
            //DateTime date2 = date1;
            //so use GetValueOrDefault() method!
            DateTime date2 = date.GetValueOrDefault();

            Console.WriteLine(date2);

            //null coalesing operator
            DateTime? date3 = null;
            DateTime date4 = date3 ?? DateTime.Today; //if date3HasValue, then set to date3; else set to DateTime.Today


        }
    }
}
