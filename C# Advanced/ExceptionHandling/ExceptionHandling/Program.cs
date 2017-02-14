using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null; //init streamReader
            try
            {
                streamReader = new StreamReader(@"C:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an error occurred.");
            }
            //finally blocks execute no matter what
            finally // make sure that Stream is ALWAYS closed
            {
                if(streamReader != null)
                    streamReader.Dispose();
            }
        }
    }
}
