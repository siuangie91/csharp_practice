using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class TrackLikes
    {
        private List<string> Friends = new List<string>();

        public TrackLikes()
        {
            EnterFriends();
        }
        private void EnterFriends()
        {
            while (true)
            {
                Console.WriteLine("Enter a friend's name or press ENTER to exit");
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    Friends.Add(input);
                }
            }

            Notify();            
        } 

        private void Notify()
        {
            var numFriends = Friends.Count;

            if (numFriends == 1)
            {
                Console.WriteLine(String.Format("{0} likes your post.", Friends[0]));
            }
            else if (numFriends == 2)
            {
                Console.WriteLine(String.Format("{0} and {1} like your post.", Friends[0], Friends[1]));
            }
            else
            {
                Console.WriteLine(String.Format("{0}, {1}, and {2} others like your post.", Friends[0], Friends[1], numFriends - 2));
            }
        }
    }
}
